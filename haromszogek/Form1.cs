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

        private int Aoldal;
        private int Boldal;
        private int Coldal;

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
            Aoldal = int.Parse(tbAoldal.Text);
            Boldal = int.Parse(tbBoldal.Text);
            Coldal = int.Parse(tbColdal.Text);


            if (Aoldal == 0 || Boldal == 0 || Coldal == 0)
            {
                MessageBox.Show("Ez nem lehet nulla", "Ez most", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var h = new Haromszog(Aoldal, Boldal, Coldal);
                if (h.szerkesztheto)
                {
                    MessageBox.Show("Kerület: " + h.kerulet + "Terület: " + h.terulet);
                }
                else
                {
                    MessageBox.Show("Nem szerkeszthető belőle háromszög");
                }


                List<string> adatok = h.adatokSzoveg();
                foreach (var a in adatok)
                {
                    lbHaromsogLista.Items.Add(a);
                }


            }

        }
    }
}
