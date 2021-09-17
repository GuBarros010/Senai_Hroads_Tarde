using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();


        TipoUsuario BuscarPorId(int idTipoUsuario);


        void Cadastrar(TipoUsuario novoTipoUsuario);


        void Atualizar(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizado);


        void Deletar(int idTipoUsuario);

    }
}
