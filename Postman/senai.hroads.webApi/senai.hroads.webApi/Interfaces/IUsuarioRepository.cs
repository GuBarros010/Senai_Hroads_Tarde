using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();


        Usuario BuscarPorId(int idUsuario);


        void Cadastrar(Usuario novoUsuario);


        void Atualizar(int idUsuario, Usuario UsuarioAtualizado);


        void Deletar(int idUsuario);

        
        Usuario BuscarPorEmailSenha(string email, string senha);
    

}
}
