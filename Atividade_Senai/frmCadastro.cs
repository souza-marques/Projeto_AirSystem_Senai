using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_Senai.Models;
using Atividade_Senai.Repositories;

namespace Atividade_Senai
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;
        public frmCadastro()
        {
            InitializeComponent();
            // o formulário é centralizado na posição atual
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.usuario = usuario;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                tbxNome.Text = usuario.Nome;
                tbxSobrenome.Text = usuario.Sobrenome;
                tbxEndereco.Text = usuario.Endereco;
                dtpNascimento.Value = usuario.Nascimento;
                tbxNumero.Text = usuario.Numero.ToString();
                tbxUsuario.Text = usuario.Username;
                tbxSenha.Text = usuario.Senha;
                tbxConfirmarSenha.Text = usuario.Senha;
            }


            

        }
       

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Arquivos de Imagens(*.jpg;*.png)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))


            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {

                    Usuario usuario = new Usuario
                    {
                        Nome = tbxNome.Text,
                        Sobrenome = tbxSobrenome.Text,
                        Endereco = tbxEndereco.Text,
                        Nascimento = dtpNascimento.Value,
                        Numero = Convert.ToInt32(tbxNumero.Text),
                        Username = tbxUsuario.Text,
                        Senha = tbxSenha.Text,
                        Admin = cbAdministrador.Checked
                    };
                    
                    repository.Cadastrar(usuario);
                   
                    
                        MessageBox.Show(" Seus dados foram salvos!",
                                        "Sucesso", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);                   
                }
                else
                {


                    this.usuario.Nome = tbxNome.Text;
                    this.usuario.Sobrenome = tbxSobrenome.Text;
                    this.usuario.Endereco = tbxEndereco.Text;
                    this.usuario.Nascimento = dtpNascimento.Value;
                    this.usuario.Numero = Convert.ToInt32(tbxNumero.Text);
                    this.usuario.Username = tbxUsuario.Text;
                    this.usuario.Senha = tbxSenha.Text;
                    this.usuario.Admin = cbAdministrador.Checked;

                    repository.Editar(usuario);
                }
                this.Close();

            }
            else
            {   
                    MessageBox.Show("Todos os campos são obrigatórios.",
                                "Alerta !", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
    }
}
