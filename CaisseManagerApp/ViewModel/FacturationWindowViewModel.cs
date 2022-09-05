using CommonClassLibrary;
using CaisseManagerApp.Model;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static CaisseManagerApp.View.FacturationWindow;

namespace CaisseManagerApp.ViewModel
{
    public class FacturationWindowViewModel : ViewModelBase
    {
        public DateTime DATE_PRINT { get; set; }
        public DateTime DATE_ECHEANCE { get; set; }
        public string TVA { get; set; }
        public string COMMANDE { get; set; }
        public string RefCommClient { get; set; }
        public bool MyProperty { get; set; }
        public FacturationWindowViewModel()
        {
            this.DATE_PRINT = DateTime.Now;
            this.DATE_ECHEANCE = DateTime.Now;
        }
        
        public ICommand CmdBtnFacturationCancel { get { return new RelayCommand(BtnCancel); } }
        private void BtnCancel()
        {
            this.MyProperty = false;

        }
        public ICommand CmdBtnFacturationOk { get { return new RelayCommand(BtnOk); } }
        private void BtnOk()
        {
            this.MyProperty = true;
        }
        public void Impression()
        {
            FactureModel _factureModel = new FactureModel
            {
                DATE_PRINT = this.DATE_PRINT,
                DATE_ECHEANCE = this.DATE_ECHEANCE,
                COMMANDE = this.COMMANDE,
                TVA = this.TVA,
                RefCommClient = this.TVA+this.COMMANDE+this.DATE_PRINT.ToString()//TODO : BUG NIVEAU DE LA CONCATENATION
            };
            _factureModel.FacturationPrint();
        }

    }
}
