﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_wpf_pangya_helper_v._1
{
    class slope
    {

        _functions func = new _functions();

        public double height_768()
        {
            double get_pixel_value = 0;

            if (func.position_pangya_screen().x >= 44 && func.position_pangya_screen().x <= 93)
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
    }
}
