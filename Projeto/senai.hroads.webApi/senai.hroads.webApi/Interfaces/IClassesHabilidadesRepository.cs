using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IClassesHabilidadesRepository
    {
        List<ClassesHabilidade> Listar();


        ClassesHabilidade BuscarPorId(int idClassesHabilidades);


        void Cadastrar(ClassesHabilidade novoClassesHabilidade);


        void Atualizar(int idClassesHabilidades, int idClasse, int idHabilidade, ClassesHabilidade ClassesHabilidadeAtualizado);


        void Deletar(int idClassesHabilidades);

    }
}
