using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public  class Sessao
    {
        public string descricao { get; set; }
        public Fisioterapeuta Fisioterapeuta { get; set; }
        public Paciente Paciente { get; set; }
        public IList<Exercicio> Exercicios { get; set; }
    }
}
