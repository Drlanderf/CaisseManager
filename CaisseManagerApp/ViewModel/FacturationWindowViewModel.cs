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
