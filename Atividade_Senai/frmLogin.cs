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
    public partial class frmLogin : Form
    {

        UsuarioRepository repository = new UsuarioRepository();
        Usuario usuario = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }
    }
}
