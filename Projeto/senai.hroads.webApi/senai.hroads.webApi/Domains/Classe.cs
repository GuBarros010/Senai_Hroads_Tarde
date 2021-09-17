using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            ClassesHabilidades = new HashSet<ClassesHabilidade>();
            Personagems = new HashSet<Personagem>();
        }

        public byte IdClasse { get; set; }
        public string NomeClasse { get; set; }

        public virtual ICollection<ClassesHabilidade> ClassesHabilidades { get; set; }
        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
