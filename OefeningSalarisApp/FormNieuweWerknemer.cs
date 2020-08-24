using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningSalarisApp
{
    public partial class FormNieuweWerknemer : Form
    {
        public FormNieuweWerknemer()
        {
            InitializeComponent();

        }
        public Werknemer nieuweWerknemer;

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (rbBediende.Checked)
            {
                nieuweWerknemer = new Werknemer(tbNaam.Text, new Salaris(brutoWedde: Convert.ToDouble(numBrutoLoon.Value)), landVanHerkomst: cbLandVanHerkomst.SelectedItem.ToString());
            }
            else if (rbProgrammeur.Checked)
            {
                nieuweWerknemer = new Programmeur(tbNaam.Text, new Salaris(brutoWedde: Convert.ToDouble(numBrutoLoon.Value)),landVanHerkomst: cbLandVanHerkomst.SelectedItem.ToString());
            }

            DialogResult = DialogResult.OK;
        }

        private void FormNieuweWerknemer_Load(object sender, EventArgs e)
        {
            cbLandVanHerkomst.Items.Add("Belgïe");
            cbLandVanHerkomst.Items.Add("Nederland");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
