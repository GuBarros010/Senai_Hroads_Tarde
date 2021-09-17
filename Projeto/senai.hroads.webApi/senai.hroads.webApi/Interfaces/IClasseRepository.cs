using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IClasseRepository
    {
        List<Classe> Listar();


        Classe BuscarPorId(int idClasse);


        void Cadastrar(Classe novoClasse);


        void Atualizar(int idClasse, Classe ClasseAtualizado);


        void Deletar(int idClasse);

    }
}
