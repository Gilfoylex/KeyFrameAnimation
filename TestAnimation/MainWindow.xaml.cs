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

namespace TestAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool show = true;
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            show = !show;
            ani.Visibility = show ? Visibility.Visible : Visibility.Hidden;
        }

        private bool start = true;
        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            var x = KeyFrameAnimation.ImageBehavior.GetAnimationController(testpic);
            if (x != null)
            {
                if (start)
                {
                    x.Stop();
                }
                else
                {
                    x.Play();
                }
                start = !start;
            }
        }
    }
}
