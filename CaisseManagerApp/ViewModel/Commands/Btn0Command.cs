using System;
using System.Windows.Input;

namespace CaisseManagerApp.ViewModel.Commands
{
    public class Btn0Command : ICommand
    {
        public ButtonViewModel _ButtonViewModel { get; set; }
        public Btn0Command(ButtonViewModel _viewModelBase)
        {
            this._ButtonViewModel = _viewModelBase;
        }
#pragma warning disable CS0067 // The event is never used
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._ButtonViewModel.SetNumber("0");
        }
    }
}
