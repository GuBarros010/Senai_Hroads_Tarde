using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idPersonagem, Personagem PersonagemAtualizada)
        {
            Personagem PersonagemBuscada = ctx.Personagems.Find(idPersonagem);

            if (PersonagemAtualizada.NomePersonagem != null)
            {
                PersonagemBuscada.NomePersonagem = PersonagemAtualizada.NomePersonagem;

                ctx.Personagems.Update(PersonagemBuscada);

                ctx.SaveChanges();
            }
        }

        public Personagem BuscarPorId(int idPersonagem)
        {
            return ctx.Personagems.FirstOrDefault(e => e.IdPersonagem == idPersonagem);
        }

        public void Cadastrar(Personagem novaPersonagem)
        {
            ctx.Personagems.Add(novaPersonagem);
            ctx.SaveChanges();
        }

        public void Deletar(int idPersonagem)
        {
            ctx.Personagems.Remove(BuscarPorId(idPersonagem));
            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagems.ToList();
        }
    }
}
