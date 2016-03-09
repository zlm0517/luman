using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace _160222PLCinterface
{
    public class SolveODE_rk
    {
        protected functionOscillatingSpring F = new functionOscillatingSpring ();
        public DenseMatrix solveODE_rk(DenseMatrix yn, double t, double u, double h)
        {
            DenseMatrix k1 = F.A() * yn + F.B(t, u);
            DenseMatrix k2 = F.A() * (yn + 0.5 * k1 * h) + F.B(t + 0.5 * h,u);
            DenseMatrix k3 = F.A() * (yn + 0.5 * k2 * h) + F.B(t + 0.5 * h, u);
            DenseMatrix k4 = F.A() * (yn + k3 * h) + F.B(t + h, u);
            return yn + (1.0 / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4) * h;
            
        }

        internal void solveODE_rk()
        {
            throw new NotImplementedException();
        }
    }
}
