using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AprendendoMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string dataSource = "datasource=localhost;username=root;password=MAK@ENG*00;database=db_agenda";

        public Form1()
        {
            InitializeComponent();

            listContatos.View = View.Details;
            listContatos.LabelEdit = true;
            listContatos.AllowColumnReorder = true;
            listContatos.FullRowSelect = true;
            listContatos.GridLines = true;

            listContatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listContatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listContatos.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            listContatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            CarregarContatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(dataSource);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = $"INSERT INTO contato (nome, email, telefone) VALUES ('{tBoxNome.Text}','{tBoxEmail.Text}','{tBoxTelefone.Text}')";
                
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("DEU TUDO CERTO!!!, Seja-bem vindo!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Erro ao cadastrar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + tBoxBuscar.Text + "%'";

                Conexao = new MySqlConnection(dataSource);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = $"SELECT * FROM contato WHERE nome LIKE {q} OR email LIKE {q}";

                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                listContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt16(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_listView = new ListViewItem(row);
                    listContatos.Items.Add(linha_listView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao procurar!");
            }
            finally
            {
                CarregarContatos();
                Conexao.Close();
            }
        }

        private void CarregarContatos()
        {
            try
            {
                Conexao = new MySqlConnection(dataSource);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = $"SELECT * FROM contato ORDER BY id DESC";

                MySqlDataReader reader = cmd.ExecuteReader();

                listContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt16(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_listView = new ListViewItem(row);
                    listContatos.Items.Add(linha_listView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao procurar!");
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
