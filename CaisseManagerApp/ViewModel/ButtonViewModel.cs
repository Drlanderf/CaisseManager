using System;
using CaisseManagerApp.ViewModel.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using CaisseManagerApp.Model;

namespace CaisseManagerApp.ViewModel
{
    public class ButtonViewModel
    {
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
        public ArticleViewModel MyArticle { get; set; }
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
            this.MyArticle = new ArticleViewModel();
        }

        public void SimpleMethod()
        {
            Debug.WriteLine("Hello");
        }
        public void SetNumber(String num)
        {
            this.MyArticle.Code_Barre += num;
        }





    }
}
