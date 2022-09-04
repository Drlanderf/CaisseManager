using CaisseManagerApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseManagerApp.ViewModel
{
    public class ShoppingBasketViewModel : ViewModelBase
    {
        public ObservableCollection <ArticleModel> ShoppingBasket;
        public ArticleModel MyArticleModel;

        public ShoppingBasketViewModel()
        {
            MyArticleModel = new ArticleModel();
            //TODO : Recup article après appuis sur "ajouter au panier"
        }
        //TODO : NEW LIST OF ARTICLE FOR THE SHOPPING BASKET
    }
}
