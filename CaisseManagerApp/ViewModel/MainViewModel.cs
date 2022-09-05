using CaisseManagerApp.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CaisseManagerApp.ViewModel
{
    public class MainViewModel: ButtonViewModel
    {
        public string TitleOfMainWindow { get; set; }
        public ObservableCollection<ArticleModel> LtArticle { get; set; }
        public MainViewModel()
        {
            TitleOfMainWindow = "Caisse Manager";
            LtArticle = new ObservableCollection<ArticleModel>();
            for (int i = 0; i < 4; i++)
            {
                ArticleModel articleModel = new ArticleModel();
                articleModel.Quantity = i+1;
                articleModel.Description = "Ceci est un test :" + i.ToString();
                articleModel.PrixUnitaire = i + 1 * 5;
                articleModel.PrixTot = articleModel.PrixUnitaire * articleModel.Quantity;
                LtArticle.Add(articleModel);
            }
        }
        #region DATABINDING
        
        #endregion
        #region test
        //public ICommand CmdCleanTable { get { return new RelayCommand(CleanTable); } }
        public ICommand CmdTestMessage => new RelayCommand(TestMessage);
        public void TestMessage()
        {
            MessageBox.Show("TEST OK !");
        }
        #endregion


            
        }
    }