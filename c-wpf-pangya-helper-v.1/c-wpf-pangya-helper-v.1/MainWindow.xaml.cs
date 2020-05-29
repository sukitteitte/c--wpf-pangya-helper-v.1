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
using System.Windows.Threading;

namespace c_wpf_pangya_helper_v._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        _functions func = new _functions();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //timer
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += screen_size_pangya;

            timer.Interval = TimeSpan.FromSeconds(0.010);
            timer.Start();
        }
        public void screen_size_pangya(object sender, EventArgs e)
        {
            bool? isChecked = powerbar.IsChecked;


            if (s800x600.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(800, 547).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(800, 547).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(800, 600).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(800, 600).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(800, 45));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(800, 36));
                }
                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(800));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }

            else if (s1024x768.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1024, 700).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1024, 700).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1024, 768).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1024, 768).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1024, 58));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1024, 36));
                }

                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1024));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1280x960.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1280, 875).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1280, 875).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1280, 960).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1280, 960).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 72));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 72));
                }

                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1280));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1280x720.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1280, 656).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1280, 656).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1280, 720).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1280, 720).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 54));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 36));
                }
                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1280));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1280x768.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1280, 700).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1280, 700).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1280, 768).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1280, 768).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 58));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 36));
                }
                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1280));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1280x800.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1280, 729).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1280, 729).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1280, 800).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1280, 800).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 60));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1280, 36));
                }


                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1280));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1366x768.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1366, 700).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1366, 700).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1366, 768).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1366, 768).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1366, 58));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1366, 36));
                }

                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1366));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1400x900.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1400, 820).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1400, 820).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1400, 900).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1400, 900).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1400, 67));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1400, 36));
                }

                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1400));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1440x990.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1440, 902).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1440, 902).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1440, 990).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1440, 990).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1440, 74));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1440, 72));
                }

                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1440));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1400x1050.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1400, 957).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1400, 957).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1400, 1050).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1400, 1050).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1400, 79));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1400, 72));
                }

                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1400));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1440x900.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1440, 820).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1440, 820).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1440, 900).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1440, 900).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1440, 67));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1440, 36));
                }

                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1440));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1440x1050.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1440, 957).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1440, 957).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1440, 1050).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1440, 1050).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1440, 79));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1440, 72));
                }


                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1440));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1600x900.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1600, 820).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1600, 820).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1600, 900).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1600, 900).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1600, 67));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1600, 36));
                }


                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1600));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1680x1050.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1680, 957).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1680, 957).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1680, 1050).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1680, 1050).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1680, 79));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1680, 72));
                }
                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1680));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);

            }
            else if (s1920x1080.IsSelected)
            {
                get_angle_degree_zero.Content = string.Format("{0:0.##}", func.angle_degree(1920, 984).Item1);
                get_angle_degree_ninety.Content = string.Format("{0:0.##}", func.angle_degree(1920, 984).Item2);

                get_center_degree_zero.Content = string.Format("{0:0.##}", func.center_degree(1920, 1080).Item1);
                get_center_degree_ninety.Content = string.Format("{0:0.##}", func.center_degree(1680, 1080).Item2);

                if (isChecked == true)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1920, 81));
                }
                else if (isChecked == false)
                {
                    get_pb.Content = string.Format("{0:0.##}", func.get_pb_value(1920, 72));
                }
                get_pixel.Content = string.Format("{0:0.##}", func.get_pixel_value(1920));

                get_position.Content = string.Format("x: {0} , y: {1}", func.position_pangya_screen().x, func.position_pangya_screen().y);
            }
        }

        private void pb_move(object sender, RoutedEventArgs e)
        {

            bool? isChecked = powerbar.IsChecked;


            if (s800x600.IsSelected)
            {

                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 45, 800, 600);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 800, 600);
                }

            }
            else if (s1024x768.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 58, 1024, 768);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1024, 768);
                }


            }
            else if (s1280x960.IsSelected)
            {
                if (isChecked == true)
                {

                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 72, 1280, 960);
                }
                else if (isChecked == false)
                {

                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 72, 1280, 960);
                }

            }
            else if (s1280x720.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 54, 1280, 720);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1280, 720);
                }


            }
            else if (s1280x768.IsSelected)
            {

                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 58, 1280, 768);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1280, 768);
                }


            }
            else if (s1280x800.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 60, 1280, 800);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1280, 800);
                }


            }
            else if (s1366x768.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 58, 1366, 768);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1366, 768);
                }


            }
            else if (s1400x900.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 67, 1400, 900);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1400, 900);
                }


            }
            else if (s1440x990.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 74, 1440, 990);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 72, 1440, 990);
                }


            }
            else if (s1400x1050.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 79, 1400, 1050);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 72, 1400, 1050);
                }
            }
            else if (s1440x900.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 67, 1440, 900);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1440, 900);
                }
            }
            else if (s1440x1050.IsSelected)
            {

                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 79, 1440, 1050);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 72, 1440, 1050);
                }
            }
            else if (s1600x900.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 67, 1600, 900);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 36, 1600, 900);
                }


            }
            else if (s1680x1050.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 79, 1680, 1050);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 72, 1680, 1050);
                }
            }
            else if (s1920x1080.IsSelected)
            {
                if (isChecked == true)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 81, 1920, 1080);
                }
                else if (isChecked == false)
                {
                    double get = Convert.ToDouble(set_pb.Text);
                    func.set_pb_move(get, 72, 1920, 1080);
                }
            }
        }

        private void pixel_move(object sender, RoutedEventArgs e)
        {
            if (s800x600.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 800, 600);
            }
            else if (s1024x768.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1024, 768);
            }
            else if (s1280x960.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1280, 960);
            }
            else if (s1280x720.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1280, 720);
            }
            else if (s1280x768.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1280, 768);
            }
            else if (s1280x800.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1280, 800);
            }
            else if (s1366x768.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1366, 768);
            }
            else if (s1400x900.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1400, 900);
            }
            else if (s1440x990.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1440, 990);
            }
            else if (s1400x1050.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1400, 1050);
            }
            else if (s1440x900.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1440, 900);
            }
            else if (s1440x1050.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1440, 1050);
            }
            else if (s1600x900.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1600, 900);
            }
            else if (s1680x1050.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1680, 1050);
            }
            else if (s1920x1080.IsSelected)
            {
                double get = Convert.ToDouble(set_pixel.Text);
                func.set_pixel_move(get, 1920, 1080);
            }
        }
    }
}
