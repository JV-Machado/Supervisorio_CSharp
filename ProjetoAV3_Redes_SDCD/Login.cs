using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAV3_Redes_SDCD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {

            Program.Usuario = TB_Usuário.Text;
            if (TB_Usuário.Text == "Usuario1" && TB_Senha.Text == "123")
            {

                this.Hide();
                MessageBox.Show("Login efetuado com sucesso");
                try
                {

                    Program.clp.Open();

                }
                catch
                {
                    MessageBox.Show("CLP não conectado");
                }
                Form1 Tela_Principal = new Form1();
                Tela_Principal.ShowDialog();


            }

            else if (TB_Usuário.Text == "Usuario2" && TB_Senha.Text == "1234")
            {

                this.Hide();
                MessageBox.Show("Login efetuado com sucesso");
                try
                {
                    Program.clp.Open();

                }
                catch
                {
                    MessageBox.Show("CLP não conectado");
                }

                Form1 Tela_Principal = new Form1();
                Tela_Principal.ShowDialog();

            }

            else if (TB_Usuário.Text == "Usuario3" && TB_Senha.Text == "12345")
            {
                this.Hide();
                MessageBox.Show("Login efetuado com sucesso");
                try
                {
                    Program.clp.Open();

                }
                catch
                {
                    MessageBox.Show("CLP não conectado");
                }
                Form1 Tela_Principal = new Form1();
                Tela_Principal.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }
    }
}
