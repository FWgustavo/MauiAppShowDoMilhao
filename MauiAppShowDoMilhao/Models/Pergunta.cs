using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppShowDoMilhao.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }

        public List<Alternativa> Alternativa { get; set; }
    }
}
