using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace CaisseManagerApp.Model
{
    public class ArticleModel : ObservableObject, INotifyPropertyChanged
    {

        #region CODE_BARRE
        private string _code_barre;
        public string Code_Barre
        {
            get { return this._code_barre; }
            set
            {
                this._code_barre = value;
                SetProperty(ref _code_barre, value);
                NotifierChangementProp("Code_Barre");
            }
        }
        #endregion
        #region DESCRIPTION
        private string _description;
        public string Description
        {
            get { return this._description; }
            set
            {
                this._description = value;
                SetProperty(ref _description, value);
                NotifierChangementProp("Description");
            }
        }
        #endregion
        #region QUANTITY
        private int _quantity;
        public int Quantity
        {
            get
            { return this._quantity; }
            set
            {
                this._quantity = value;
                SetProperty(ref _quantity, value);
                NotifierChangementProp("Quantity");

            }
        }
        #endregion
        #region PRIX_UNITAIRE
        private float _prixUnitaire;
        public float PrixUnitaire
        {
            get { return this._prixUnitaire; }
            set
            {
                this._prixUnitaire = value;
                SetProperty(ref _prixUnitaire, value);
                NotifierChangementProp("PrixUnitaire");
            }
        }
        #endregion
        #region PRIX_TOT
        private float _prixTot;
        public float PrixTot
        {
            get { return this._prixTot; }
            set
            {
                this._prixTot = value;
                SetProperty(ref _prixTot, value);
                NotifierChangementProp("PrixTot");
            }
        }
        #endregion
        public ArticleModel(){        }
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
