using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    struct linEq
    {
        double k;
        double b;
        public linEq(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0)
                return "Решений нет";
            else
            {
                double x = -1 * b / k;
                return $"Решение уравнения = {x:0.000}";
            }
        }
    }
}
