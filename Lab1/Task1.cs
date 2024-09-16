using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Task1
    {
        public static double Convertor(double degree, string scale,string scale_second)
        {
            switch(scale)
            {
                case "C":
                    if(scale == scale_second)
                    {
                        return degree;
                    }
                    else if(scale_second == "K")
                    {
                        return degree + 273.15;
                    }
                    else if(scale_second == "F")
                    {
                        return degree * 9 / 5 +32;
                    }
                    break;
                case "K":
                    if(scale == scale_second)
                    {
                        return degree;
                    }
                    else if(scale_second == "C")
                    {
                        return degree - 273.15;
                    }
                    else if(scale_second == "F")
                    {
                        return degree * 9/5 -459.67;
                    }
                    break;
                case "F":
                    if (scale == scale_second)
                    {
                        return degree;
                    }
                    else if (scale_second == "C")
                    {
                        return (degree - 32) * 5/9;
                    }
                    else if (scale_second == "K")
                    {
                        return (degree + 459.67) * 5/9;
                    }
                    break;
            }
            return 0;
        }
    }
}
