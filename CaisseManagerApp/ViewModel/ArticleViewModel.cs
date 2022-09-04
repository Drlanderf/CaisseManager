using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaisseManagerApp.Model;
using CommonClassLibrary;

namespace CaisseManagerApp.ViewModel
{
    public class ArticleViewModel : ViewModelBase
    {
        public ArticleModel MyArticleModel;
        public ArticleViewModel()
        {
            MyArticleModel = new ArticleModel();
        }
        public string Code_Barre
        {
            get
            { return MyArticleModel.code_barre; }
            set
            {
                MyArticleModel.code_barre = Code_Barre;
                //SetProperty(ref code_barre, value);
                NotifierChangementProp("Code_Barre");

            }
        }
        public void SetCode_Barre(string cbTmp)
        {
            this.Code_Barre = cbTmp;
        }

        public string Description
        {
            get { return MyArticleModel.description; }
            set
            {
                MyArticleModel.description = Description;
                NotifierChangementProp("Description");
            }
        }
        public void SetDescription(bool WhatToDo)//True = Comportement "normal" , False = Comportement "reset"
        {
            if (WhatToDo)
            {
                DBManagementViewModel commande = new DBManagementViewModel();
                Description = commande.Row_Article(MyArticleModel.code_barre, "Description").ToString();
            }
            else
                Description = "0";

        }
        public float PrixUnitaire
        {
            get { return MyArticleModel.prixU; }
            set
            {
                MyArticleModel.prixU = PrixUnitaire;
                //SetProperty(ref prixU, value);
                NotifierChangementProp("PrixUnitaire");
            }
        }
        public void SetPrixUnitaire(bool WhatToDo)//True = Comportement "normal" , False = Comportement "reset"
        {
            if (WhatToDo)
            {
                DBManagementViewModel commande = new DBManagementViewModel();
                PrixUnitaire = float.Parse(commande.Row_Article(MyArticleModel.code_barre, "PV"));
            }
            else
                PrixUnitaire = 0;
        }
        public int Quantity
        {
            get
            { return MyArticleModel.quantity; }
            set
            {
                MyArticleModel.quantity = Quantity;
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
            { return MyArticleModel.qtyTmp; }
            set
            {
                MyArticleModel.qtyTmp = QtyTmp;
                //SetProperty(ref qtyTmp, value);
                NotifierChangementProp("QtyTmp");
            }
        }
        public void SetQtyTmp(string cbTmp)
        {
            this.QtyTmp = cbTmp;
        }
    }
}
