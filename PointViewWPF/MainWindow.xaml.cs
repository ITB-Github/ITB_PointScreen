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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PointViewModel pvm = new PointViewModel();
            this.DataContext = pvm;
            AddHotKey();
        }


        void AddHotKey()
        {
            try
            {
                RoutedCommand choose = new RoutedCommand();
                choose.InputGestures.Add(new KeyGesture(Key.D, ModifierKeys.Control));
                CommandBindings.Add(new CommandBinding(choose, choose_Execute));

                RoutedCommand fullScreen = new RoutedCommand();
                fullScreen.InputGestures.Add(new KeyGesture(Key.F, ModifierKeys.Control));
                CommandBindings.Add(new CommandBinding(fullScreen, fullScreen_Execute));

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
            btnInfo_Click(sender, e);

            //throw new NotImplementedException();
        }

        private void fullScreen_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            btnMakeFullScreen_Click(sender, e);
        }

        private void choose_Execute(object sender, ExecutedRoutedEventArgs e)
        {

            btnChooseTeam_Click(sender, e);
            //throw new NotImplementedException();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.MouseDown += MainWindow_MouseDown;
            //

        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }    
        }

        private void btnMakeFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                this.Left = 0;
                this.Top = 0;
                return;
            }
            if(this.DataContext!=null)
            {
                PointViewModel pvm = this.DataContext as PointViewModel;
                pvm.MakeFullScreen();
            } 
        }

        HotkeyView hotkeyView;
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            if (hotkeyView == null)
                hotkeyView = new HotkeyView();
            hotkeyView.Show();
        }
        internal void AttachHotkeyView(HotkeyView view)
        {
            hotkeyView = view;
        }

        private void btnChooseTeam_Click(object sender, RoutedEventArgs e)
        {
            if(this.DataContext !=null)
            {
                PointViewModel pvm = DataContext as PointViewModel;
                pvm.GetTeamToChoose();
            }
        }

        
    }

    
}
