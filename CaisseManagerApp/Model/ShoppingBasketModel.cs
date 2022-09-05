using CommonClassLibrary;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CaisseManagerApp.Model
{
    public class ShoppingBasketModel : ObservableObject, INotifyPropertyChanged
    {
        private List<ArticleModel> _shopingBasket;
        public List<ArticleModel> ShoppingBasket
        {
            get { return this._shopingBasket; }
            set
            {
                this._shopingBasket = value;
                SetProperty(ref _shopingBasket, value);
                NotifierChangementProp("ShoppingBasket");
            }
        }
        public ShoppingBasketModel(){        }


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
