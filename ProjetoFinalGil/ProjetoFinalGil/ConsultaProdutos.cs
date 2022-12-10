using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalGil
{
    public partial class frmConsultarEstoque : Form
    {
        public frmConsultarEstoque()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            radTomate.Checked = false;
            radCebola.Checked = false;

            radDebora.Checked = false;
            radCereja.Checked = false;

            radRoxa.Checked = false;
            radBranca.Checked = false;


            picBranca.Visible = false;
            radBranca.Visible = false;

            picRoxa.Visible = false;
            radRoxa.Visible = false;

            picDebora.Visible = false;
            radDebora.Visible = false;


            picCereja.Visible = false;
            radCereja.Visible = false;

            lblMensagem.Visible = false;
        }

        private void radTomate_CheckedChanged(object sender, EventArgs e)
        {
            // deixe visible os tomates
            picDebora.Visible = true;
            radDebora.Visible = true;

            // deixe visible os cereja
            picCereja.Visible = true;
            radCereja.Visible = true;

            picRoxa.Visible = false;
            radRoxa.Visible = false;

            picBranca.Visible = false;
            radBranca.Visible = false;

            lblMensagem.Visible = false;
        }

        private void radCebola_CheckedChanged(object sender, EventArgs e)
        {
            picRoxa.Visible = true;
            radRoxa.Visible = true;

            picBranca.Visible = true;
            radBranca.Visible = true;

            picDebora.Visible = false;
            radDebora.Visible = false;


            picCereja.Visible = false;
            radCereja.Visible = false;

            lblMensagem.Visible = false;
        }

        private void radDebora_CheckedChanged(object sender, EventArgs e)
        {

            picCereja.Visible = false;
            radCereja.Visible = false;

            lblMensagem.Text = "O tomate selecionado foi um " + radDebora.Text;
            lblMensagem.Visible = true;

        }

        private void radCereja_CheckedChanged(object sender, EventArgs e)
        {


            picDebora.Visible = false;
            radDebora.Visible = false;

            lblMensagem.Text = "O tomate selecionada foi um " + radCereja.Text;
            lblMensagem.Visible = true;
        }

        private void radRoxa_CheckedChanged(object sender, EventArgs e)
        {

            picBranca.Visible = false;
            radBranca.Visible = false;

            lblMensagem.Text = "A cebola selecionada foi uma " + radRoxa.Text;
            lblMensagem.Visible = true;


           
        }

        private void radBranca_CheckedChanged(object sender, EventArgs e)
        {
            picRoxa.Visible = false;
            radRoxa.Visible = false;

            lblMensagem.Text = "A cebola selecionada foi uma " + radBranca.Text;
            lblMensagem.Visible = true;

            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
