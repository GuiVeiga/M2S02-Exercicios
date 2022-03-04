using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    [Serializable]
    public class Notas
    {
        public string Aluno { get; set; }

        public int Nota1 { get; set; }

        public int Nota2 { get; set; }

        public int Nota3 { get; set; }
    }
}
