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
    public class MainViewModel:ObservableObject
    {
        public MainViewModel()
        {


        }
        //public ICommand CmdCleanTable { get { return new RelayCommand(CleanTable); } }
        public ICommand CmdTestMessage { get { return new RelayCommand(TestMessage); } }
        public void TestMessage()
        {
            MessageBox.Show("TEST OK !");
        }
    }
}
