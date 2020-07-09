using System;

namespace c_wpf_pangya_helper_v._1
{
    class slope
    {

        _functions func = new _functions();
     

        public double height_768()
        {
            double get_pixel_value = 0;

                if (func.position_pangya_screen().x >= 43 && func.position_pangya_screen().x <= 92)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((43) - Math.Abs(x));

                }

                else if (func.position_pangya_screen().x <= 142 && func.position_pangya_screen().x >= 93)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((142) - Math.Abs(x));

                }
            
            return get_pixel_value;
        }


        public double height_900()
        {
            double get_pixel_value = 0;
          
                if (func.position_pangya_screen().x >= 51 && func.position_pangya_screen().x <= 108)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((51) - Math.Abs(x));

                }

                else if (func.position_pangya_screen().x <= 166 && func.position_pangya_screen().x >= 109)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((166) - Math.Abs(x));

                }
            
            return get_pixel_value;
        }

        public double height_960()
        {
            double get_pixel_value = 0;

            if (func.position_pangya_screen().x >= 54 && func.position_pangya_screen().x <= 116)
            {
                double x = func.position_pangya_screen().x;
                get_pixel_value = Math.Abs((54) - Math.Abs(x));

            }

            else if (func.position_pangya_screen().x <= 178 && func.position_pangya_screen().x >= 116)
            {
                double x = func.position_pangya_screen().x;
                get_pixel_value = Math.Abs((178) - Math.Abs(x));

            }

            return get_pixel_value;
        }

        public double smallslopeall() {
            double get_pixel_value = 0;

            
                if (func.position_pangya_screen().x >= 27 && func.position_pangya_screen().x <= 58)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((27) - Math.Abs(x));

                }

                else if (func.position_pangya_screen().x <= 89 && func.position_pangya_screen().x >= 58)
                {
                    double x = func.position_pangya_screen().x;
                    get_pixel_value = Math.Abs((89) - Math.Abs(x));

                }
            

            return get_pixel_value;
        }
    }
}
