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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNieuweWerknemer.Enabled = false;
            Werknemer Geert = new Werknemer("Geert",new Salaris(contract : Salaris.TypeContract.weekcontract)); 
            Werknemer Frank = new Werknemer("Frank" ,new Salaris(brutoWedde: 2200));
            Werknemer Daniel = new Werknemer("Daniel", new Salaris(contract: Salaris.TypeContract.weekcontract), landVanHerkomst: "Nederland") ;
            Werknemer Sofia = new Werknemer("Sofia", new Salaris(brutoWedde: 3110), landVanHerkomst: "Nederland");

            /*List<Werknemer> mijnWerknemers = new List<Werknemer>() { Geert, Frank, Daniel, Sofia };*/

            Bedrijf Sofina = new Bedrijf("Sofina", "BE 0403.219.397");
            Bedrijf Dexia = new Bedrijf("Dexia", "BE 0458.548.296");
            Bedrijf Proximus = new Bedrijf("Proximus", "BE 0202.239.951");

            List<Bedrijf> mijnBedrijven = new List<Bedrijf>() { Sofina, Dexia, Proximus };
            cbBedrijven.DataSource = mijnBedrijven;
            

            Sofina.WerknemerToevoegen(Geert);
            Sofina.WerknemerToevoegen(Frank);
            Sofina.WerknemerToevoegen(Daniel);

            Dexia.WerknemerToevoegen(new Werknemer("Bart"));
            Dexia.WerknemerToevoegen(new Werknemer("Bert"));
            Dexia.WerknemerToevoegen(new Werknemer("Jan"));

            Proximus.WerknemerToevoegen(Sofia);
            Proximus.WerknemerToevoegen(new Werknemer("Dirk"));
            Proximus.WerknemerToevoegen(new Werknemer("Jos"));
            cbBedrijven.SelectedIndex = -1;
        }

        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWerknemers.SelectedIndex > -1)
            {
                Werknemer geselecteerdeWerknemer = (Werknemer)cbWerknemers.SelectedItem;
                lblLandVanHerkomst.Text = geselecteerdeWerknemer.LandVanHerkomst.ToString();
                lblSalaris.Text = "€ " + geselecteerdeWerknemer.Salaris.BerekenNetto().ToString();
                lblTypeContract.Text = geselecteerdeWerknemer.Salaris.Contract.ToString();
            }
            btnVerwijderWerknemer.Visible = (cbWerknemers.SelectedIndex > -1) ? true : false;
        }

        private void cbBedrijven_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNieuweWerknemer.Enabled = (cbBedrijven.SelectedIndex > -1) ? true : false;
            if (cbBedrijven.SelectedIndex > -1)
            {
                Bedrijf geselecteerdeBedrijf = (Bedrijf)cbBedrijven.SelectedItem;
                cbWerknemers.DataSource = null;
                cbWerknemers.DataSource = geselecteerdeBedrijf.Werknemers;
                ClearLabels();
            }
        }
        
        public void ClearLabels()
        {
            cbWerknemers.SelectedIndex = -1;
            lblLandVanHerkomst.Text = string.Empty;
            lblSalaris.Text = string.Empty;
            lblTypeContract.Text = string.Empty;
        }

        private void btnVerwijderWerknemer_Click(object sender, EventArgs e)
        {
            Bedrijf geselecteerdBedrijf = (Bedrijf)cbBedrijven.SelectedItem;
            int index = cbWerknemers.SelectedIndex;
            geselecteerdBedrijf.VerwijderWerknemer(index);

            cbWerknemers.DataSource = null;
            cbWerknemers.DataSource = geselecteerdBedrijf.Werknemers;
            ClearLabels();
        }

        private void btnNieuweWerknemer_Click(object sender, EventArgs e)
        {
            Bedrijf geselecteerdBedrijf = (Bedrijf)cbBedrijven.SelectedItem;
            DialogResult result = MessageBox.Show(
                $"Wil je een nieuwe werknemer toevoegen aan {geselecteerdBedrijf}",
                "Gebruiker toevoegen?",
                MessageBoxButtons.YesNo);

            if (result==DialogResult.Yes)
            {
                FormNieuweWerknemer form = new FormNieuweWerknemer();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Werknemer nieuweWerknemer = form.nieuweWerknemer;
                    geselecteerdBedrijf.WerknemerToevoegen(nieuweWerknemer);
                }
            }
            cbWerknemers.DataSource = null;
            cbWerknemers.DataSource = geselecteerdBedrijf.Werknemers;
        }
    }
}
