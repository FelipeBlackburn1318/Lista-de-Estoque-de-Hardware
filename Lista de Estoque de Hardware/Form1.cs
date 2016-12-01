using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Lista_de_Estoque_de_Hardware
{
    public partial class Form1 : Form
    {
        SQLiteConnection conect = new SQLiteConnection(@"data source = C:\hwbd.blkflp");
        SQLiteCommand cmd;
        Boolean define = false;
        public Form1()
        {
            InitializeComponent();
            selectAllTabela();
            MessageBox.Show("Antes de Deletar ou alterar, selecione uma peça por ID");
        }
        public int statusIbm()
        {
            if (chkIBM.Checked)
                return 1;
            else
                return 0;
        }
        public int statusQbex()
        {
            if (chkQbex.Checked)
                return 1;
            else
                return 0;
        }
        public int statusDell()
        {
            if (chkDell.Checked)
                return 1;
            else
                return 0;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            conect.Open();
            try
            {
                cmd = new SQLiteCommand("Insert into Hardware values ('" + txtNome.Text.ToUpper() + "'," + npdQtd.Value + ",(SELECT MAX(ID) FROM Hardware)+1 ,'" + statusIbm() + "','" + statusQbex() + "','" + statusDell() + "');", conect);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {
            }

            conect.Close();
            selectAllTabela();

        }
        public void selectAllTabela()
        {
            conect.Open();
            try
            {
                cmd = new SQLiteCommand("SELECT ID, peca AS [nome da peça] ,qtdPeca AS [Quantidade de peças], compat_IBM_Lenovo AS [IBM Lenovo], compat_Qbex AS Qbex, compat_Dell AS Dell FROM Hardware", conect);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable pecas = new DataTable();
                da.Fill(pecas);
                dtgTabela.DataSource = pecas;
                npdQtd.Value = 1;
            }
            catch
            {
            }
            conect.Close();
            }

        private void btnSelectID_Click(object sender, EventArgs e)
        {
            try
            {
                int compat_IBM, compat_Qbex, compat_Dell, totPecas;
                cmd = new SQLiteCommand("SELECT ID, peca AS [nome da peça] ,qtdPeca AS [Quantidade de peças], compat_IBM_Lenovo AS [IBM Lenovo], compat_Qbex AS Qbex, compat_Dell AS Dell FROM Hardware WHERE ID = " + npdID.Value + ";", conect);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable pecaEspecifica = new DataTable();
                da.Fill(pecaEspecifica);
                dtgTabela.DataSource = pecaEspecifica;
                cmd.Dispose();
                conect.Open();
                cmd = new SQLiteCommand("SELECT ID, peca, qtdPeca , compat_IBM_Lenovo, compat_Qbex, compat_Dell FROM Hardware WHERE ID = " + npdID.Value, conect);
                var leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    totPecas = Convert.ToInt32(leitor["qtdPeca"]);
                    txtNome.Text = leitor["peca"].ToString();
                    npdQtd.Value = totPecas;
                    compat_Dell = Convert.ToInt32(leitor["compat_Dell"]);
                    compat_IBM = Convert.ToInt32(leitor["compat_IBM_Lenovo"]);
                    compat_Qbex = Convert.ToInt32(leitor["compat_Qbex"]);

                    if (compat_Dell == 1)
                        chkDell.Checked = true;
                    else
                        chkDell.Checked = false;

                    if (compat_Qbex == 1)
                        chkQbex.Checked = true;
                    else
                        chkQbex.Checked = false;

                    if (compat_IBM == 1)
                        chkIBM.Checked = true;
                    else
                        chkIBM.Checked = false;

                    define = true;
                }
            }
            catch
            {

            }
            finally
            {
                conect.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (define)
            {
                conect.Open();
                try
                {
                    if (MessageBox.Show("Realmente deseja excluir a peça " + txtNome.Text.ToUpper() + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cmd = new SQLiteCommand("DELETE FROM Hardware WHERE ID = " + npdID.Value, conect);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                }
                catch
                {

                }
                conect.Close();
                selectAllTabela();

                txtNome.Clear();
                chkDell.Checked = false;
                chkIBM.Checked = false;
                chkQbex.Checked = false;
                npdQtd.Value = 0;
                npdID.Value = 0;

                define = false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            selectAllTabela();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (define)
            {
                conect.Open();
                try
                {
                    cmd = new SQLiteCommand("UPDATE Hardware SET peca = '" + txtNome.Text.ToUpper() + "',qtdPeca = " + npdQtd.Value + ",compat_IBM_Lenovo = " + statusIbm() + ",compat_Qbex = " + statusQbex() + ",compat_Dell = " + statusDell() + " WHERE ID = " + npdID.Value, conect);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch
                {

                }
                conect.Close();
                selectAllTabela();
                define = false;
            }
        }
    }
}