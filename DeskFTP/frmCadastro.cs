using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskFTP
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            txtQtdFotosEncadernadas.Text = "";
        }

        private void btnLocalizarDiretorio_Click(object sender, EventArgs e)
        {
            fbdLocalizadorPasta.ShowDialog();
            txtLocalFotos.Text = fbdLocalizadorPasta.SelectedPath;
        }

        private void chkBrutasCD_CheckedChanged(object sender, EventArgs e)
        {
            txtQtdFotosEncadernadas.Text = string.Empty;
            txtQtdFotosEncadernadas.ReadOnly = false;

            ddlDimensoes.Enabled = true;
            ddlDimensoes.SelectedIndex = -1;



            if (chkBrutasCD.Checked)
            {
                chkEncadernadas.Checked = false;
                txtQtdFotosEncadernadas.ReadOnly = true;
                ddlDimensoes.Enabled = false;
            }

        }

        private void chkEncadernadas_CheckedChanged(object sender, EventArgs e)
        {

            txtQtFotosBrutas.Text = string.Empty;
            txtQtFotosBrutas.ReadOnly = false;

            if (chkEncadernadas.Checked)
            {
                chkBrutasCD.Checked = false;
                txtQtFotosBrutas.ReadOnly = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Essa ação irá fechar a janela atual e todas as informações não salvas serão perdidas. Deseja Continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado.ToString().ToLower().Equals("yes"))
            {
                this.Close();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDataRealizacao.Text = e.Start.ToString("dd/MM/yyyy");
            calendario.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calendario.Show();
        }

        private void calendario_MouseLeave(object sender, EventArgs e)
        {
            calendario.Hide();
        }

        private void btnCriarProjeto_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                CriarXML();
            }
        }

        private bool validarCampos()
        {
            bool camposValidados = true;
            int resultadointeiro = 0;
            DateTime resultadoData = DateTime.MinValue;


            if (!txtDataRealizacao.Text.Equals("  /  /"))
            {
                DateTime.TryParse(txtDataRealizacao.Text, out resultadoData);

                if (resultadoData.Equals(DateTime.MinValue))
                {
                    MessageBox.Show("Data Inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    camposValidados = false;
                }
            }

            if (!string.IsNullOrEmpty(txtQtdFotosEncadernadas.Text.Trim())) 
            {
                int.TryParse(txtQtdFotosEncadernadas.Text, out resultadointeiro);

                if (resultadointeiro == 0) 
                {
                    MessageBox.Show("Quantidade de fotos encadernadas inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    camposValidados = false;
                }
            }

            if (!string.IsNullOrEmpty(txtQtFotosBrutas.Text.Trim()))
            {
                resultadointeiro = 0;
                int.TryParse(txtQtFotosBrutas.Text, out resultadointeiro);

                if (resultadointeiro == 0)
                {
                    MessageBox.Show("Quantidade de fotos brutas em CD inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    camposValidados = false;
                }
            }

            return camposValidados;
        }

        private void CriarXML()
        {

        }
    }
}
