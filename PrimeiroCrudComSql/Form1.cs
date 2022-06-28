using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeiroCrudComSql
{
    public partial class Form1 : Form
    {
        SqlConnection conecta = new SqlConnection("Data source=.;Initial Catalog = AgendaCrud; Integrated Security = true");
        SqlCommand comando;
        SqlDataAdapter adaptar;
        int Id = 0;

        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExibirDados()
        {
            try
            {
                conecta.Open();
                DataTable dt = new DataTable();
                adaptar = new SqlDataAdapter("SELECT * FROM CADASTRO", conecta);
                adaptar.Fill(dt);
                visualizarCadastros.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro: " + exc.Message);
            }
            finally
            {
                conecta.Close();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;

            txtNome.Focus();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    comando = new SqlCommand("INSERT INTO CADASTRO VALUES" + "(@NOME , @TELEFONE, @EMAIL, @ENDERECO)", conecta);
                    conecta.Open();

                    comando.Parameters.AddWithValue("@NOME", txtNome.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text.Trim());
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text.ToUpper().Trim());

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Realizado com sucesso!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro: " + exc.Message);
                }
                finally
                {
                    conecta.Close();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Os campos Nome e email são obrigatorios!");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    comando = new SqlCommand("UPDATE CADASTRO SET NOME = @NOME, TELEFONE = @TELEFONE, EMAIL = @EMAIL, ENDERECO = @ENDERECO WHERE ID = @ID)", conecta);
                    conecta.Open();

                    comando.Parameters.AddWithValue("@NOME", txtNome.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text.Trim());
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@ID", Id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Realizado com sucesso!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro: " + exc.Message);
                }
                finally
                {
                    conecta.Close();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Os campos Nome e email são obrigatorios!");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deeseja excluir este registro?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    comando = new SqlCommand("DELETE CADASTRO WHERE Id=@ID", conecta);
                    conecta.Open();

                    comando.Parameters.AddWithValue("@ID", Id);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Resgistro deletado com sucesso!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro: " + exc.Message);
                }
                finally
                {
                    conecta.Close();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para ser deletado!");
            }
        }

        private void visualizarCadastros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = int.Parse(visualizarCadastros.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = visualizarCadastros.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefone.Text = visualizarCadastros.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = visualizarCadastros.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEndereco.Text = visualizarCadastros.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Se deu erro aqui vc fez algo de errado!" + exc.Message);
            }
        }
    }
}
