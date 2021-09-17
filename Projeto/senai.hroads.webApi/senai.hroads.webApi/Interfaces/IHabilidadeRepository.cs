using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();


        Habilidade BuscarPorId(int idHabilidade);


        void Cadastrar(Habilidade novoHabilidade);


        void Atualizar(int idHabilidade, Habilidade HabilidadeAtualizado);


        void Deletar(int idHabilidade);

    }
}
