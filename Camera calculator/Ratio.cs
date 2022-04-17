using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_calculator
{
    public class Ratio
    {
        public double Top = 1;
        public double Bottom = 1;

        public Ratio(String input)
        {
            string[] width_height = input.Split(':');
            
            if (!Double.TryParse(width_height[0], out this.Top))
            {
            }

            if (width_height.Length > 1)
            {
                if (!Double.TryParse(width_height[1], out this.Bottom))
                {
                }
            }
        }
    }
}
