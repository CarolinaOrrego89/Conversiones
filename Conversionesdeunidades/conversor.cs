using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversionesdeunidades
{
    class conversor
    {
        double[][] valores = new double[1][] {
            
 new double[]{1, 1.32, 0.93, 796.28, 18.60, 61.71}
     };
        public double monedas(double unitario, int de, int a, int option)
        {
            return valores[option][a] / valores[option][de] * unitario;
        }
    }
}
