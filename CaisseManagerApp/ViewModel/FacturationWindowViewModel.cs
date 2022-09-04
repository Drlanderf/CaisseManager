using CommonClassLibrary;
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
        public bool MyProperty { get; set; }
        public FacturationWindowViewModel()
        {
            this.DATE_PRINT = DateTime.Now;
            this.DATE_ECHEANCE = DateTime.Now;
        }
        public DateTime DATE_PRINT { get; set; }
        public DateTime DATE_ECHEANCE { get; set; }
        public string TVA { get; set; }
        public string COMMANDE { get; set; }
        public string RefCommClient { get; set; }
        public string Rayon { get; set; }
        public void FacturationPrint()
        {
            ExcelManagement myFacture = new ExcelManagement();
            myFacture.Facture(this.DATE_PRINT,
                    this.DATE_ECHEANCE,
                    this.TVA,
                    this.COMMANDE);
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

    }
}
