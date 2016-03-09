using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace _160222PLCinterface
{
    public class Motor
    {
        static double J = 3.2284*Math.Exp (-6);
        static double b = 3.5077 * Math.Exp(-6);
        static double K=0.0274;
        static double R=4.0;
        static double L = 2.75 * Math.Exp(-6);

        public DenseMatrix A()
        {
            DenseMatrix tmp = new DenseMatrix(3, 3);
            tmp[0, 0] = 0;
            tmp[0, 1] = 1;
            tmp[0, 2] = 0;
            tmp[1, 0] = 0;
            tmp[1, 1] = -b/J;
            tmp[1, 2] = K/J;
            tmp[2, 0] = 0;
            tmp[2, 1] = -K/L;
            tmp[2, 2] = -R/L;
            return tmp;
        }
        public DenseMatrix B()
        {
            DenseMatrix tmp = new DenseMatrix(3,1);
            tmp[0, 0] = 0;
            tmp[1, 0] = 0;
            tmp[2, 0] = 1/L;
            return tmp;
        }
       
    }
}
