using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace _160222PLCinterface
{
    public class functionOscillatingSpring
    {
        static double Amp = 2;
        static double m = 10;
        static double k = 100;
        static double L = 10;
        static double x0 = 40;
        static double delx = m * 9.81 / k;

        public DenseMatrix A()
        {
            DenseMatrix tmp = new DenseMatrix(2, 2);
            tmp[0, 0] = 0;
            tmp[0, 1] =1;
            tmp[1, 0]=-k/m;
            tmp[1, 1] = 0;
            return tmp;
        }
        public DenseMatrix B(double t,double u) 
        {
            DenseMatrix tmp = new DenseMatrix(2, 1);
            tmp[0, 0]=0;
            tmp[1, 0]=-k/m *(Amp*Math.Sin(2*Math.PI/L*t)+x0+delx) + 9.81 + 1/m *u ;
            return tmp;
        }
    }
}
