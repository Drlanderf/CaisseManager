using CaisseManagerApp.View;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CaisseManagerApp.ViewModel
{
    internal class UCCaisseManagerTopMenuViewModel : ViewModelBase
    {

        public ICommand CmdBtnFacturation { get { return new RelayCommand(BtnFacturation); } }
        private void BtnFacturation()
        {
            FacturationWindow facturationForm = new FacturationWindow();
            facturationForm.ShowDialog();
            NotifierChangementProp("Show");
            /*if (facturationForm.ShowDialog() == true)//ShowDialog est bloquant donc utile pour les formulaire
            {
                //TODO: Trouver pourquoi cela ne s'affiche pas
            }*/
        }
    }
}
