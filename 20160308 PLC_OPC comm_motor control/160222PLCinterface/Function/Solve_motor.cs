using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace _160222PLCinterface
{
    public class Solve_motor
    {
        protected Motor M = new Motor();
        public DenseMatrix solve_motor(DenseMatrix yn, double t, double V, double h)
        {
            DenseMatrix k1 =M.A()*yn + M.B()*V;
            DenseMatrix k2 = M.A() * (yn + 0.5 * k1 * h) + M.B() * V;
            DenseMatrix k3 = M.A() * (yn + 0.5 * k2 * h) + M.B() * V;
            DenseMatrix k4 = M.A() * (yn + k3 * h) + M.B() * V;
            return yn +(1.0/6.0)*(k1 + 2*k2 + 2*k3 + k4)*h;
        }
        
    }
}
