using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CaisseManagerApp.Model;
using CaisseManagerApp.View.UserControls;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace CaisseManagerApp.ViewModel
{ //TODO : revenir en arrière et faire en sorte d'avoir le moins possible de UC
    public class UCKeypadViewModel : ObservableObject
    {
        public UCData MyUCData { get; set; }
        public string tmp { get; set; }
        public ArticleViewModel MyArticle { get; set; }
        
        public UCKeypadViewModel()
        {
            MyUCData = new UCData();
            MyArticle = new ArticleViewModel();



        }
        //Keypad Number
        public ICommand CmdBtn0_Click{ get { return new RelayCommand(Btn0_Click); } }
        private void Btn0_Click()
        {
            SetNumber("0");
        }
        public ICommand CmdBtn1_Click{ get { return new RelayCommand(Btn1_Click); } }
        private void Btn1_Click()
        {
            SetNumber("1");
        }
        public ICommand CmdBtn2_Click{ get { return new RelayCommand(Btn2_Click); } }
        private void Btn2_Click()
        {
            SetNumber("2");
        }
        public ICommand CmdBtn3_Click{ get { return new RelayCommand(Btn3_Click); } }
        private void Btn3_Click()
        {
            SetNumber("3");
        }
        public ICommand CmdBtn4_Click{ get { return new RelayCommand(Btn4_Click); } }
        private void Btn4_Click()
        {
            SetNumber("4");
        }
        public ICommand CmdBtn5_Click{ get { return new RelayCommand(Btn5_Click); } }
        private void Btn5_Click()
        {
            SetNumber("5");
        }
        public ICommand CmdBtn6_Click{ get { return new RelayCommand(Btn6_Click); } }
        private void Btn6_Click()
        {
            SetNumber("6");
        }
        public ICommand CmdBtn7_Click{ get { return new RelayCommand(Btn7_Click); } }
        private void Btn7_Click()
        {
            SetNumber("7");
        }
        public ICommand CmdBtn8_Click{ get { return new RelayCommand(Btn8_Click); } }
        private void Btn8_Click()
        {
            SetNumber("8");
        }
        public ICommand CmdBtn9_Click{ get { return new RelayCommand(Btn9_Click); } }
        private void Btn9_Click()
        {
            SetNumber("9");
        }
        //Keypad Function
        public ICommand CmdBtnSupprimer_Click { get { return new RelayCommand(Supprimer_Click); } }
        private void Supprimer_Click()
        {
            
        }
        public ICommand CmdBtnEtoile_Click { get { return new RelayCommand(Etoile_Click); } }
        private void Etoile_Click()
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
            int Cmpt = 0;
            if (Cmpt == 0)
            {
                tmp = "♪";
                MyArticle.SetCode_Barre(MyUCData.txtResult.Text);
                MyArticle.SetDescription(true);
                MyArticle.SetPrixUnitaire(true);
                MyArticle.SetQuantity(1);
                Cmpt++;
            }
            if (Cmpt == 1)
            {

            }

        }







        void SetNumber(String num)
        {
            if (MyUCData.txtResult.Text == "0")
                MyUCData.txtResult.Text = num;
            else
                MyUCData.txtResult.Text = MyUCData.txtResult.Text + num;
        }
    }
}
