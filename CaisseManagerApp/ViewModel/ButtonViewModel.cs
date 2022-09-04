using System;
using CaisseManagerApp.ViewModel.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using CaisseManagerApp.Model;
using System.ComponentModel;

namespace CaisseManagerApp.ViewModel
{
    public class ButtonViewModel : ViewModelBase, INotifyPropertyChanged
    {
        /// <summary>
        /// Contient les différentes méthodes utilisées par les différents boutons
        /// </summary>
        #region Propiétés
        public Btn0Command Btn0Command { get; set; }
        public Btn1Command Btn1Command { get; set; }
        public Btn2Command Btn2Command { get; set; }
        public Btn3Command Btn3Command { get; set; }
        public Btn4Command Btn4Command { get; set; }
        public Btn5Command Btn5Command { get; set; }
        public Btn6Command Btn6Command { get; set; }
        public Btn7Command Btn7Command { get; set; }
        public Btn8Command Btn8Command { get; set; }
        public Btn9Command Btn9Command { get; set; }
        public BtnQuantityCommand BtnQuantityCommand { get; set; }
        public BtnClearCommand BtnClearCommand { get; set; }
        public BtnEnterCommand BtnEnterCommand { get; set; }
        public ArticleModel MyArticle { get; set; }
        #endregion
        #region Constructeur
        public ButtonViewModel()
        {
            this.Btn0Command = new Btn0Command(this);
            this.Btn1Command = new Btn1Command(this);
            this.Btn2Command = new Btn2Command(this);
            this.Btn3Command = new Btn3Command(this);
            this.Btn4Command = new Btn4Command(this);
            this.Btn5Command = new Btn5Command(this);
            this.Btn6Command = new Btn6Command(this);
            this.Btn7Command = new Btn7Command(this);
            this.Btn8Command = new Btn8Command(this);
            this.Btn9Command = new Btn9Command(this);
            this.BtnQuantityCommand = new BtnQuantityCommand(this);
            this.BtnClearCommand = new BtnClearCommand(this);
            this.BtnQuantityCommand = new BtnQuantityCommand(this);
            this.MyArticle = new ArticleModel();
        }
        #endregion
        #region méthodes
        public void SimpleMethod()
        {
            Debug.WriteLine("Hello");
        }
        public void SetNumber(String num)
        {
            this.MyArticle.Code_Barre += num;
            Debug.WriteLine(MyArticle.Code_Barre);
            NotifierChangementProp("Code_Barre");
        }
        public void SetQuantity(int num)
        {
            this.MyArticle.Quantity = num;
            this.MyArticle.Code_Barre = String.Empty;
            NotifierChangementProp("Quantity");
            Debug.WriteLine(MyArticle.Quantity);
        }
        public void Enter()
        {
            this.MyArticle.PrixTot = this.MyArticle.Quantity * this.MyArticle.PrixUnitaire;
        }
        public void Clear()
        {
            this.MyArticle.Code_Barre = String.Empty;
            this.MyArticle.Quantity = 0;
            this.MyArticle.Description = String.Empty;
            this.MyArticle.PrixUnitaire = 0;
            this.MyArticle.PrixTot = 0;
        }
        #endregion

        #region Implémentation interface Notify property changed
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
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
