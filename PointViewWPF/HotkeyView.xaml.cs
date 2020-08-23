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

namespace PointViewWPF
{
    /// <summary>
    /// Interaction logic for HotkeyView.xaml
    /// </summary>
    public partial class HotkeyView : Window
    {
        public HotkeyView()
        {
            InitializeComponent();

            AddHotKey();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Collapsed;
        }

        void AddHotKey()
        {
            try
            {
                
                RoutedCommand information = new RoutedCommand();
                information.InputGestures.Add(new KeyGesture(Key.H, ModifierKeys.Control));
                CommandBindings.Add(new CommandBinding(information, information_Execute));
            }
            catch
            {
                MessageBox.Show("HotKey Not Available");
            }


        }

        private void information_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            //throw new NotImplementedException();
            if (this.Visibility == Visibility.Visible)
                this.Visibility = Visibility.Collapsed;
        }
    }
}
