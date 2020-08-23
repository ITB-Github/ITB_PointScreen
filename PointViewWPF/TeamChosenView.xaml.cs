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
using System.Windows.Shapes;
using PointPresenterController;

namespace PointViewWPF
{
    /// <summary>
    /// Interaction logic for TeamChosenView.xaml
    /// </summary>
    public partial class TeamChosenView : Window
    {
        public TeamChosenView()
        {
            InitializeComponent();
            this.DataContext = new TeamChosenViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.DataContext!=null)
            {
                this.Visibility = Visibility.Collapsed;
                TeamChosenViewModel tvm = this.DataContext as TeamChosenViewModel;
                tvm.ChooseTeam(cbxTeamChosen.SelectedValue.ToString());
            }    
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Collapsed;
        }
    }
}
