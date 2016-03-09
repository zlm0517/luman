using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Double;
using OPCSiemensDAAutomation;


namespace _160222PLCinterface
{
    public partial class Form1 : Form
    {
        /*
        OPCServer MyOpcServer;
        OPCGroup MyOpcGroup;
        OPCItem[] MyOpcItem = new OPCItem[4];
        int[] ServerHandle = new int[4];
        const int READASYNC_ID = 1;
        const int WRITEASYNC_ID = 2;
        */
        public Form1()
        {
            InitializeComponent();
        }
        /*
        protected functionOscillatingSpring F = null;
        public List<DenseMatrix> Y = new List<DenseMatrix>();
        public List<double> T = new List<double>();
        */       
        protected Motor M = null;
        public List<double> T = new List<double>();
        public List<DenseMatrix> Y = new List<DenseMatrix>();
        private void but_conn_Click(object sender, EventArgs e)
        {
           
           /******************************** OPC Client s  ****************/
            /*
           try
           {
               MyOpcServer = new OPCServer();
               MyOpcServer.Connect("OPC.SimaticNet", "192.168.0.10");
               MyOpcGroup = MyOpcServer.OPCGroups.Add("MyGroup1");
               MyOpcGroup.IsActive = true;
               MyOpcGroup.IsSubscribed = true;
               MyOpcGroup.DeadBand = 0;
               MyOpcGroup.UpdateRate = 100;
               MyOpcItem[0] = MyOpcGroup.OPCItems.AddItem("S7:[S7 connection_1]MREAL8", 1);
               MyOpcItem[1] = MyOpcGroup.OPCItems.AddItem("S7:[S7 connection_1]MREAL16", 2);
               MyOpcItem[2] = MyOpcGroup.OPCItems.AddItem("S7:[S7 connection_1]MREAL28", 3);
               MyOpcItem[3] = MyOpcGroup.OPCItems.AddItem("S7:[S7 connection_1]MREAL36", 4);
               ServerHandle[0] = MyOpcItem[0].ServerHandle;
               ServerHandle[1] = MyOpcItem[1].ServerHandle;
               ServerHandle[2] = MyOpcItem[2].ServerHandle;
               ServerHandle[3] = MyOpcItem[3].ServerHandle;
           }
           catch(System.Exception error)
           {
               MessageBox.Show(error.Message, "Result-connect server", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           */
            /******************************** OPC Client e ****************/
            
            Solve(sender, e);
        }
        #region
        /******************************** OPC Client R/W Start  ****************/
        /*
        private void but_write_Click(object sender, EventArgs e)
        {
            try
            {
                MyOpcItem[0].Write(tex_w1.Text);
                MyOpcItem[1].Write(tex_w2.Text);
            }
            catch(System.Exception error)
            {
                MessageBox.Show(error.Message, "result_syn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_read_Click(object sender, EventArgs e)
        {
            object ItemValues;
            object Qualities;
            object TimeStamps;
            try
            {
                MyOpcItem[0].Read(1, out ItemValues, out Qualities, out TimeStamps);
                tex_r1_value.Text = string.Format("{0}", ItemValues);
                text_r1_quality.Text = string.Format("{0}", Qualities);
                text_r1_timestamps.Text = string.Format("{0}", TimeStamps);

                MyOpcItem[1].Read(2, out ItemValues, out Qualities, out TimeStamps);
                tex_r2_value.Text = string.Format("{0}", ItemValues);
                tex_r2_quality.Text = string.Format("{0}", Qualities);
                tex_r2_timestamps.Text = string.Format("{0}", TimeStamps);


            }
            catch (System.Exception error)
            {
                MessageBox.Show(error.Message, "result_syn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         * */
        /******************************** OPC Client R/W end ****************/
        #endregion
        /*       
        private void solve (object sender, EventArgs e)
       {
           functionOscillatingSpring f = new functionOscillatingSpring();
           double h = 0.01;
           double t_end = 50;
           double u = 0;
           DenseMatrix y0 = new DenseMatrix(2, 1);
           y0[0, 0] = -40;
           y0[1, 0] = 0;
           SetInitialCondition(y0, f);
           SolveODE_RK4(t_end, h, u);
       }
      public void SetInitialCondition(DenseMatrix y0, functionOscillatingSpring f)
       {
           f = F;
           T.Add(0.0);
           Y.Add(y0);
       }
        
       public void SolveODE_RK4(double t_end, double h, double u)
       {
           double t = 0;
           int N = (int)(t_end / h);
           DenseMatrix y = Y[0];
           double x_ideal = -40;
           double u0 = 98.1;
           double[] error = new double[N];
           double[] derror = new double[N];
           double[] ierror = new double[N];
           double K = -150;
           double Ti = 0.1;
           double Td = 0.5;
           double Kp = -500;
           double Ki = 10;
           double Kd = -20;
           
           SolveODE_rk S = new SolveODE_rk();

           string Mode = "PID_2";                     
           for (int i = 1; i < N; i++)
           {
               y= S.solveODE_rk(y, t, u, h);
               t = t + h;
               T.Add(t);
               Y.Add(y);
               if (Mode.Equals("none"))
               {
                   u = 0;
               } 
               if(Mode.Equals("PID_1"))
               {
                   error[i] = x_ideal - y.Values[0];                  
                   ierror[i] = error.Sum()* h;
                   derror[i] = (error[i] - error[i - 1]) / h;
                   //u=u0-(K * (error[i] +(1/ Ti) * ierror[i]));
                   u = u0- (K * (error[i] +(1/ Ti) * ierror[i] + Td * derror[i]));
               }
               if (Mode.Equals("PID_2"))
               {
                   error[i] = x_ideal - y.Values[0];
                   ierror[i] = error.Sum() * h;
                   derror[i] = (error[i] - error[i - 1]) / h;
                   u = u0 - (Kp * error[i] + Ki * ierror[i] + Kd * derror[i]);
               }
               
               if(Mode.Equals("OPC_1"))
               {
                   MyOpcItem[0].Write(Y[i].Values[0]);
                   //System.Threading.Thread.Sleep(1);
                   object ItemValues_1;//, ItemValues_2
                   object Qualities_1;//, Qualities_2
                   object TimeStamps_1;//, TimeStamps_2
                   MyOpcItem[1].Read(1, out ItemValues_1, out Qualities_1, out TimeStamps_1);
                   string str_ = Convert.ToString(ItemValues_1);
                   object u1 = float.Parse(str_);
                   u=u0-(float)u1;                
                   /*
                   MyOpcItem[1].Read(1, out ItemValues_1, out Qualities_1, out TimeStamps_1);
                   MyOpcItem[2].Read(2, out ItemValues_2, out Qualities_2, out TimeStamps_2);
                   string str_1 = Convert.ToString(ItemValues_1);
                   string str_2 = Convert.ToString(ItemValues_2);
                   object u1 = float.Parse(str_1);
                   object u2 = float.Parse(str_2);
                   u = (float)u1 +(float)u2;
                     
               }
                
               if (Mode.Equals("OPC_2"))
               {
                   error[i] = x_ideal - y.Values[0];
                   MyOpcItem[0].Write(error[i]);
                   ierror[i] = error.Sum() * h;
                   MyOpcItem[2].Write(ierror[i]);
                   derror[i] = (error[i] - error[i - 1])/h;
                   MyOpcItem[1].Write(derror[i]);
                   object ItemValues;
                   object Qualities;
                   object TimeStamps;
                   MyOpcItem[3].Read(1, out ItemValues, out Qualities, out TimeStamps);
                   string str = Convert.ToString(ItemValues);
                   object u1 = float.Parse(str);
                   u = u0 - (float)u1;
               }

           }

           MyOpcItem[0].Write(-40);
           // output to text file
           string path = "";
           path = System.IO.Directory.GetCurrentDirectory();
           path = path + "\\output.txt";
           StreamWriter sw = File.CreateText(path);           

               for (int i = 1; i < N; i++)
               {
                   chart1.Series["Series1"].Points.AddXY(T[i], Y[i].Values[0]);
                   sw.WriteLine(Y[i].Values[0].ToString());
               }
                
         }
        
       */

        public void Solve(object sender,EventArgs e)
        {
            double t_end = 10;
            double h=0.001;            
            DenseMatrix y0=new DenseMatrix (3,1);
            y0 [0,0]=0;
            y0 [1,0]=0;
            y0 [2,0]=0;
            Motor m= new Motor();
            double V = 100;
            SetInitialCondition(y0,m);
            Solve_RK(t_end, h, V);
        }
        public void SetInitialCondition(DenseMatrix y0, Motor m)
        {
            m = M;
            T.Add(0.0);
            Y.Add(y0);
        }
        public void Solve_RK(double t_end,double h, double V)
        {
            double t=0;            
            int N=(int)(t_end/h);
            DenseMatrix y = Y[0];
            double V0 = 0;
            double y_ideal = 1;
            Solve_motor S = new Solve_motor();
            string Mode = "none";
            double[] error = new double[N];
            double[] derror = new double[N];
            double[] ierror = new double[N];
            double Kp = -100;
            double Ki = 10;
            double Kd = 0.4;

            for (int i = 1; i < N; i++)
            {
                y = S.solve_motor(y, t, V, h);
                t = t + h;
                T.Add(t);
                Y.Add(y);
                if (Mode.Equals("PID"))
                {
                    error[i] = y_ideal - y.Values[0];
                    derror[i] = (error[i] - error[i - 1] )/ h;
                    ierror[i] = error.Sum() * h;
                    V = V0-(Kp*error[i]+Ki*ierror[i]+Kd*derror[i]);
                }
                
                if(Modal.Equals("none"))
                {
                    V=1000;
                }
                
            }
            for (int i = 0; i < N; i++)
            {
                chart1.Series["Series2"].Points.AddXY(T[i], Y[i].Values[0]);
            }
        }

        
    }
    
}
