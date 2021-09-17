using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();


        TipoHabilidade BuscarPorId(int idTipoHabilidade);


        void Cadastrar(TipoHabilidade novoTipoHabilidade);


        void Atualizar(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizado);


        void Deletar(int idTipoHabilidade);

    }
}
