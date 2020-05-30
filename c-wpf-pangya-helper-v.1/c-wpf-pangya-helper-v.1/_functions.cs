using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace c_wpf_pangya_helper_v._1
{
    class _functions
    {

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpTitleName);

        [DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        public static extern int GetCursorPos(out POINT lpPoint); // bool

        [DllImport("user32.dll")]
        static extern int ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll")]
        static extern int ClientToScreen(IntPtr hWnd, ref POINT lpPoint); // bool

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        //[StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
            public POINT(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }
        public IntPtr hwnd()
        {
            IntPtr hwnd = FindWindow(null, "Pangya Fresh Up!");
            return hwnd;
        }

        public POINT position_pangya_screen()
        {

            POINT position;
            GetCursorPos(out position);
            ScreenToClient(hwnd(), ref position);
            return position;

        }

        public Tuple<double, double> angle_degree(int screenWidth, int yPos)
        {
            double x = position_pangya_screen().x;
            double y = position_pangya_screen().y;

            double angle_degree_x = (x - (screenWidth / 2));
            double angle_degree_y = (y - yPos);

            double radians = Math.Atan2(Math.Abs(angle_degree_y), Math.Abs(angle_degree_x));
            double degree = radians * (180 / Math.PI);

            double angle_degree_0 = 90 - degree;
            double angle_degree_90 = degree;


            return Tuple.Create(angle_degree_0, angle_degree_90); // Item1 , Item2
        }

        public Tuple<double, double> center_degree(int screenWidth, int screenHeight)
        {
            double x = position_pangya_screen().x;
            double y = position_pangya_screen().y;

            double center_degree_x = (x - (screenWidth / 2));
            double center_degree_y = (y - (screenHeight / 2));

            double radians = Math.Atan2(Math.Abs(center_degree_y), Math.Abs(center_degree_x));
            double degree = radians * (180 / Math.PI);

            double center_degree_0 = 90 - degree;
            double center_degree_90 = degree;

            return Tuple.Create(center_degree_0, center_degree_90); // Item1, Item2

        }

        public double get_pixel_value(int screenWidth) //xPos screen width
        {
            double x = position_pangya_screen().x;

            double get_pixel_value = Math.Abs((screenWidth / 2) - Math.Abs(x));
            return get_pixel_value;
        }

        public double get_pb_value(int screenWidth, int pb_distance) //xPos screen width , 1pixel
        {
            double x = position_pangya_screen().x;

            double get_pixel_value = Math.Abs((screenWidth / 2) - Math.Abs(x));

            double get_pb_value = get_pixel_value / pb_distance;
            return get_pb_value;
        }

        public void movehelp(int xPos, int yPos)
        {
            POINT position = new POINT(xPos, yPos);

            double width = SystemParameters.VirtualScreenWidth;
            double height = SystemParameters.VirtualScreenHeight;

            ClientToScreen(hwnd(), ref position);
            double convertedPointX = (position.x * 65535) / (width - 1);
            double convertedPointY = (position.y * 65535) / (height - 1);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, Convert.ToInt32(convertedPointX), Convert.ToInt32(convertedPointY), 0, 0);
        }

        public void set_pb_move(double getPb, int pb_distance, int screenWidth, int screenHeight) // textbox.text (pb),1pixel,screenWidth,screenHeight
        {
            double pixel = getPb * pb_distance;
            double xPos = (screenWidth / 2) + (pixel);
            POINT position = new POINT(Convert.ToInt32(xPos), screenHeight / 2);

            double width = SystemParameters.VirtualScreenWidth;
            double height = SystemParameters.VirtualScreenHeight;

            ClientToScreen(hwnd(), ref position);
            double convertedPointX = (position.x * 65535) / (width - 1);
            double convertedPointY = (position.y * 65535) / (height - 1);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, Convert.ToInt32(convertedPointX), Convert.ToInt32(convertedPointY), 0, 0);
        }

        public void set_pixel_move(double getPixel, int screenWidth, int screenHeight) //textbox.text (pixel)
        {
            double xPos = (screenWidth / 2) + (getPixel);
            POINT position = new POINT(Convert.ToInt32(xPos), screenHeight / 2);
            double width = SystemParameters.VirtualScreenWidth;
            double height = SystemParameters.VirtualScreenHeight;

            ClientToScreen(hwnd(), ref position);
            double convertedPointX = (position.x * 65535) / (width - 1);
            double convertedPointY = (position.y * 65535) / (height - 1);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, Convert.ToInt32(convertedPointX), Convert.ToInt32(convertedPointY), 0, 0);
        }
    }
}
