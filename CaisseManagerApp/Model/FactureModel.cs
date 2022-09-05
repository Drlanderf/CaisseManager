using CommonClassLibrary;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CaisseManagerApp.Model
{
    public class FactureModel : ObservableObject, INotifyPropertyChanged
    {


        /// <summary>
        /// Propriétés
        /// </summary>
        #region DATE PRINT
        private DateTime _DATE_PRINT;
        public DateTime DATE_PRINT
        {
            get { return this._DATE_PRINT; }
            set
            {
                this._DATE_PRINT = value;
                SetProperty(ref _DATE_PRINT, value);
                NotifierChangementProp("DATE_PRINT");
            }
        }
        #endregion
        #region DATE ECHEANCE
        private DateTime _DATE_ECHEANCE;
        public DateTime DATE_ECHEANCE
        {
            get { return this._DATE_ECHEANCE; }
            set
            {
                this._DATE_ECHEANCE = value;
                SetProperty(ref _DATE_ECHEANCE, value);
                NotifierChangementProp("DATE_ECHEANCE");
            }
        }
        #endregion
        #region TVA
        private string _TVA;
        public string TVA
        {
            get { return this._TVA; }
            set
            {
                this._TVA = value;
                SetProperty(ref _TVA, value);
                NotifierChangementProp("TVA");
            }
        }
        #endregion
        #region COMMANDE
        private string _COMMANDE;
        public string COMMANDE
        {
            get { return this._COMMANDE; }
            set
            {
                this._COMMANDE = value;
                SetProperty(ref _COMMANDE, value);
                NotifierChangementProp("COMMANDE");
            }
        }
        #endregion
        #region RefCommClient
        private string _RefCommClient;
        public string RefCommClient
        {
            get { return this._TVA; }
            set
            {
                this._RefCommClient = value;
                SetProperty(ref _RefCommClient, value);
                NotifierChangementProp("RefCommClient");
            }
        }
        #endregion
        #region Détail Article
        private List<ArticleModel> _detailArticle;
        public List<ArticleModel> DetailArticle
        {
            get { return this._detailArticle; }
            set
            {
                this._detailArticle = value;
                SetProperty(ref _detailArticle, value);
                NotifierChangementProp("DetailArticle");
            }
        }
        #endregion






        public FactureModel(){        }


        public void FacturationPrint()
        {
            ExcelManagement myFacture = new ExcelManagement();
            myFacture.Facture(this.DATE_PRINT,
                    this.DATE_ECHEANCE,
                    this.TVA,
                    this.COMMANDE,this.RefCommClient);
        }
        #region Implémentation interface Notify property changed
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifierChangementProp(string Nomprop)
        {
            PropertyChangedEventHandler gestion = this.PropertyChanged;
            if (gestion != null)
            {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(Nomprop);
                gestion.Invoke(this, e);
            }
        }
        #endregion
    }
}
