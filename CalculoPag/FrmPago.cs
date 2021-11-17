using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Domain.Cuota;
namespace CalculoPag
{
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            List<Cuotas> cuotas;
            


        }

        private void printf (List<Cuotas> c)
        {
            foreach(Cuotas cuotas in c)
            {
                if(c == null)
                {
                    throw new Exception($"No se ingreso ningun valor ¡ArgumentNullException!");
                    
                }

                else
                if(c != null)
                {

                    rtbMostrar.Text = $"{c.ToString()} \n";
                }

            }

        }






    }
}
