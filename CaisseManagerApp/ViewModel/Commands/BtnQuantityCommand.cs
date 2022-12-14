using System;
using System.Windows.Input;

namespace CaisseManagerApp.ViewModel.Commands
{
    public class BtnQuantityCommand : ICommand
    {
        public ButtonViewModel _ButtonViewModel { get; set; }
        public BtnQuantityCommand(ButtonViewModel _viewModelBase)
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
            this._ButtonViewModel.SetQuantity(int.Parse(_ButtonViewModel.MyArticle.Code_Barre));
            _ButtonViewModel.MyArticle.Code_Barre = String.Empty;
        }
    }
}
