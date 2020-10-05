using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haromszogek
{
    public partial class frmFo : Form
    {

        private double Aoldal;
        private double Boldal;
        private double Coldal;

        public frmFo()
        {
            Aoldal = 0;
            Boldal = 0;
            Coldal = 0;
            InitializeComponent();
            tbAoldal.Text = Aoldal.ToString();
            tbBoldal.Text = Boldal.ToString();
            tbColdal.Text = Coldal.ToString();
            lbHaromsogLista.Items.Clear();

        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHaromsogLista.Items.Count >0)
            {
                lbHaromsogLista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs mit törölni");
            }
            

            
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                Aoldal = Convert.ToDouble(tbAoldal.Text);
                Boldal = Convert.ToDouble(tbBoldal.Text);
                Coldal = Convert.ToDouble(tbColdal.Text);


                if (Aoldal == 0 || Boldal == 0 || Coldal == 0)
                {
                    MessageBox.Show("Ez nem lehet nulla", "Ez most", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var h = new Haromszog(Aoldal, Boldal, Coldal);
                    List<string> adatok = h.adatokSzoveg();
                    foreach (var a in adatok)
                    {
                        lbHaromsogLista.Items.Add(a);
                    }


                }
            }
            catch (Exception esc)
            {
                MessageBox.Show("Számot adj meg!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbAoldal.Focus();

            }

        }
    }
}
