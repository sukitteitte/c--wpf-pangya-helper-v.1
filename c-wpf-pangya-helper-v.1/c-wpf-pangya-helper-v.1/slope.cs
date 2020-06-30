using System;

namespace c_wpf_pangya_helper_v._1
{
    class slope
    {

        _functions func = new _functions();
     

        public double height_768()
        {
            double get_pixel_value = 0;

                if (func.position_pangya_screen().x >= 44 && func.position_pangya_screen().x <= 92)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((44) - Math.Abs(x));

                }

                else if (func.position_pangya_screen().x <= 141 && func.position_pangya_screen().x >= 93)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((141) - Math.Abs(x));

                }
            
            return get_pixel_value;
        }


        public double height_900()
        {
            double get_pixel_value = 0;
          
                if (func.position_pangya_screen().x >= 52 && func.position_pangya_screen().x <= 108)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((52) - Math.Abs(x));

                }

                else if (func.position_pangya_screen().x <= 165 && func.position_pangya_screen().x >= 109)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((165) - Math.Abs(x));

                }
            
            return get_pixel_value;
        }

        public double smallslopeall() {
            double get_pixel_value = 0;

            
                if (func.position_pangya_screen().x >= 28 && func.position_pangya_screen().x <= 58)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((28) - Math.Abs(x));

                }

                else if (func.position_pangya_screen().x <= 88 && func.position_pangya_screen().x >= 58)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((88) - Math.Abs(x));

                }
            

            return get_pixel_value;
        }
    }
}
