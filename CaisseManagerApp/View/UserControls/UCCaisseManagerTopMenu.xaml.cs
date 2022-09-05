using CaisseManagerApp.Model;
using CaisseManagerApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaisseManagerApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for UCCaisseManagerTopMenu.xaml
    /// </summary>
    public partial class UCCaisseManagerTopMenu : UserControl
    {
        public UCCaisseManagerTopMenu()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void BtnFacturation(object sender, RoutedEventArgs e)
        {
            FacturationWindowViewModel maFacture = new FacturationWindowViewModel();
            FacturationWindow facturationForm = new FacturationWindow();
            facturationForm.DataContext = maFacture;

            if (facturationForm.ShowDialog() == true) //ShowDialog est bloquant donc utile pour les formulaire
                maFacture.Impression();

        }
    }
}
