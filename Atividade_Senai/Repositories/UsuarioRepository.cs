using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade_Senai.Models;

namespace Atividade_Senai.Repositories
{
    class UsuarioRepository
    {

        private static List<Usuario> usuarios;

        private static int contador = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();
            }
        }

        public List<Usuario> listarTodos()
        {
            return usuarios;
        }

        public void Cadastrar(Usuario usuario)
        {
            usuario.Codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void Editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.Codigo == usuario.Codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }
        public void Deletar(int Codigo)
        {
            Usuario usuario = usuarios.Find(x => x.Codigo == Codigo);

            usuarios.Remove(usuario);
        }

        public Usuario BuscarUsuario(string user, string senha)
        {
            if (user != null && senha != null)
            {
                Usuario usuario = usuarios.Find(x => x.Username == user && x.Senha == senha);
                return usuario;
            }
            else
            {
                return null;
            }
        }





    }
}
