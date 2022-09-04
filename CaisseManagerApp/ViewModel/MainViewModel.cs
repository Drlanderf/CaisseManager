using CaisseManagerApp.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CaisseManagerApp.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        public string Tmp { get; set; }
        public ArticleModel MyArticle { get; set; }
        public MainViewModel()
        {
            MyArticle = new ArticleModel();
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

        //Keypad Function
        public ICommand CmdBtnSupprimer_Click { get { return new RelayCommand(Supprimer_Click); } }
        private void Supprimer_Click()
        {

        }
        public ICommand CmdBtnPoint_Click { get { return new RelayCommand(Point_Click); } }
        private void Point_Click()
        {

        }
        public ICommand CmdBtnCancel_Click { get { return new RelayCommand(Cancel_Click); } }
        private void Cancel_Click()
        {

        }
        public ICommand CmdBtnEnter_Click { get { return new RelayCommand(Enter_Click); } }
        private void Enter_Click()
        {
            /*int Cmpt = 0;
            if (Cmpt == 0)
            {
                Tmp = "♪";
                MyArticle.SetCode_Barre(.txtCode_Barre.Text);
                MyArticle.SetDescription(true);
                MyArticle.SetPrixUnitaire(true);
                MyArticle.SetQuantity(1);
                Cmpt++;
            }
            if (Cmpt == 1)
            {

            }*/
            
        }
    }




}
