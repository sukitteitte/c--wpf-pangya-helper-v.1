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

namespace c_wpf_pangya_helper_v._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] screen { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            screen_size_pangya();
        }
        public void screen_size_pangya()
        {
            screen = new string[] {
                "800x600", //angle = y.547 , pb = 45
                "1024x768",//angle = y.700 , pb = 58
                "1280x960",//angle = y.875 , pb = 72
                "1280x720",//angle = y.656 , pb = 54
                "1280x768",//angle = y.700 , pb = 58
                "1280x800",//angle = y.729 , pb = 60
                "1366x768",//angle = y.700 , pb = 58
                "1400x900",//angle = y.820 , pb = 67
                "1440x990",//angle = y.902 , pb = 74
                "1400x1050",//angle = y.957 , pb = 79
                "1440x900",//angle = y.820 , pb = 67
                "1440x1050",//angle = y.957 , pb = 79
                "1600x900",//angle = y.820 , pb = 67
                "1680x1050",//angle = y.957 , pb = 79
                "1920x1080"};//angle = y.984 , pb = 81
            DataContext = this;

        }
    }
}
