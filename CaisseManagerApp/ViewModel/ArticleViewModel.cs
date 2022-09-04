using CaisseManagerApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseManagerApp.ViewModel
{
    public class ArticleViewModel : ViewModelBase
    {
        public ArticleModel MyArticle;
        public ArticleViewModel()
        {
            this.MyArticle = new ArticleModel();
        }
        public string Code_Barre
        {
            get
            { return MyArticle.code_barre; }
            set
            {
                MyArticle.code_barre += Code_Barre;
                //SetProperty(ref code_barre, value);
                NotifierChangementProp("Code_Barre");

            }
        }
        /*public void SetCode_Barre(string cbTmp)
        {
            this.Code_Barre = cbTmp;
        }*/

        public string Description
        {
            get { return MyArticle.description; }
            set
            {
                MyArticle.description = Description;
                NotifierChangementProp("Description");
            }
        }
        public void SetDescription(bool WhatToDo)//True = Comportement "normal" , False = Comportement "reset"
        {
            if (WhatToDo)
            {
                DBManagementViewModel commande = new DBManagementViewModel();
                Description = commande.Row_Article(MyArticle.code_barre, "Description").ToString();
            }
            else
                Description = "0";

        }
        public float PrixUnitaire
        {
            get { return MyArticle.prixU; }
            set
            {
                MyArticle.prixU = PrixUnitaire;
                //SetProperty(ref prixU, value);
                NotifierChangementProp("PrixUnitaire");
            }
        }
        public void SetPrixUnitaire(bool WhatToDo)//True = Comportement "normal" , False = Comportement "reset"
        {
            if (WhatToDo)
            {
                DBManagementViewModel commande = new DBManagementViewModel();
                PrixUnitaire = float.Parse(commande.Row_Article(MyArticle.code_barre, "PV"));
            }
            else
                PrixUnitaire = 0;
        }
        public int Quantity
        {
            get
            { return MyArticle.quantity; }
            set
            {
                MyArticle.quantity = Quantity;
                //SetProperty(ref quantity, value);
                NotifierChangementProp("Quantity");

            }
        }
        public void SetQuantity(int QtyTmp)
        {
            this.Quantity = QtyTmp;
        }
        public string QtyTmp
        {
            get
            { return MyArticle.qtyTmp; }
            set
            {
                MyArticle.qtyTmp = QtyTmp;
                //SetProperty(ref qtyTmp, value);
                NotifierChangementProp("QtyTmp");
            }
        }
        public void SetQtyTmp(string cbTmp)
        {
            this.QtyTmp = cbTmp;
        }
        public void SimpleMethod()
        {
            Debug.WriteLine("Hello");
        }



    }
}
