using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

 
        private void Storyboard_Completed(object sender, EventArgs e)
        {
            Debug.WriteLine("===========Storyboard_Completed============");
        }

        private void Storyboard_CurrentGlobalSpeedInvalidated(object sender, EventArgs e)
        {
            Debug.WriteLine("===========Storyboard_CurrentGlobalSpeedInvalidated============");
        }

        private void Storyboard_CurrentStateInvalidated(object sender, EventArgs e)
        {
            Debug.WriteLine("===========Storyboard_CurrentStateInvalidated============");
        }

        private void Storyboard_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            Debug.WriteLine("===========Storyboard_CurrentTimeInvalidated============");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(this, "state_1", true);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(this, "state_2", true);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(this, "state_3", true);
        }
    }
}
