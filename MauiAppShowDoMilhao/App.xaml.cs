using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        
        
            List<Pergunta> perguntas_faceis = new()
            {
                new Pergunta
                {
                    Id = 1,
                    Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                        new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                        new Alternativa { Correta = false, Descricao = "GASOSO" },
                        new Alternativa { Correta = false, Descricao = "VAPOROSO" },
                    }
                },
                new Pergunta 
                {
                    Id= 2,
                    Enunciado = "Quem é a namorada do Mickey?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "MARGARIDA"},
                        new Alternativa {Correta = true, Descricao = "MINNIE"},
                        new Alternativa {Correta = false, Descricao = "A PEQUENA SEREIA"},
                        new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO"},
                    }
                },
                new Pergunta
                {
                    Id= 3,
                    Enunciado = "Qual era o apelido da cantora Elis Regina?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "GAUCHINHA"},
                        new Alternativa {Correta = false, Descricao = "PAULISTINHA"},
                        new Alternativa {Correta = true, Descricao = "PIMENTINHA"},
                        new Alternativa {Correta = false, Descricao = "ANDORINHA"},
                    }
                },
                new Pergunta
                {
                    Id= 4,
                    Enunciado = "Quem proclamou a república no Brasil em 1889?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
                        new Alternativa {Correta = false, Descricao = "MARECHAL RONDON"},
                        new Alternativa {Correta = false, Descricao = "DON PEDRO II"},
                        new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO"},
                    }
                },
            };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
