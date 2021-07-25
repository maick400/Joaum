using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joaum2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            abrirPrendas(new Prendas());
            
        }


    //************************************Metods*****************************//

        private void abrirPrendas(Object Frm)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form frPrenda = Frm as Form;

            frPrenda.TopLevel = false;
            panel2.Controls.Add(frPrenda);
            panel2.Tag = FontHeight;
            frPrenda.Show();
            
        }



    //-----------------------------------------------------------------------//
    }
}
