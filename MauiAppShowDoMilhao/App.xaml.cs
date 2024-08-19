using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {


        static List<Pergunta> perguntas_faceis = new()
            {
                new Pergunta
                {
                    Id = 1,
                    Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Rio de Janeiro" },
                        new Alternativa { Correta = true, Descricao = "Rio Grande do Sul" },
                        new Alternativa { Correta = false, Descricao = "Santa Catarina" },
                        new Alternativa { Correta = false, Descricao = "Goiás" },
                    }
                },
                new Pergunta
                {
                    Id= 2,
                    Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Líquido"},
                        new Alternativa {Correta = true, Descricao = "Sólido"},
                        new Alternativa {Correta = false, Descricao = "Gasoso"},
                        new Alternativa {Correta = false, Descricao = "Vaporoso"},
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
                    Enunciado = "Quem é a namorada do Mickey?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Margarida"},
                        new Alternativa {Correta = true, Descricao = "Minnie"},
                        new Alternativa {Correta = false, Descricao = "A Pequena Sereia"},
                        new Alternativa {Correta = false, Descricao = "Olívia Palito"},
                    }
                },
                new Pergunta
                {
                    Id = 5,
                    Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "CUCA"},
                        new Alternativa {Correta = false, Descricao = "Negrinho do pastoreio"},
                        new Alternativa {Correta = false, Descricao = "Boitatá"},
                        new Alternativa { Correta = true, Descricao = "Saci-Pererê" },
                    }
                },
                new Pergunta
                {
                    Id = 6,
                    Enunciado = "Fidel Castro nasceu em que país?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Jamaica"},
                        new Alternativa {Correta = true, Descricao = "Cuba"},
                        new Alternativa {Correta = false, Descricao = "Él Salvador"},
                        new Alternativa { Correta = false, Descricao = "México" },
                    }
                },
                new Pergunta
                {
                    Id = 7,
                    Enunciado = "Quem é o patrono do exército brasileiro?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Marechal Deodoro"},
                        new Alternativa {Correta = false, Descricao = "Barão de Mauá"},
                        new Alternativa {Correta = true, Descricao = "Duque de Caxias"},
                        new Alternativa { Correta = false, Descricao = "Marquês de Pombal" },
                    }
                },
                new Pergunta
                {
                    Id = 8,
                    Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Raul Gil"},
                        new Alternativa {Correta = false, Descricao = "Bolinha"},
                        new Alternativa {Correta = false, Descricao = "Flávio Cavalcanti"},
                        new Alternativa { Correta = true, Descricao = "Chacrinha" },
                    }
                },
                new Pergunta
                {
                    Id = 9,
                    Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Raul Gil"},
                        new Alternativa {Correta = false, Descricao = "Bolinha"},
                        new Alternativa {Correta = false, Descricao = "Flávio Cavalcanti"},
                        new Alternativa { Correta = true, Descricao = "Chacrinha" },
                    }
                },
                new Pergunta
                {
                    Id = 10,
                    Enunciado = "O que era Frankenstein, de Mary Shelley?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = true, Descricao = "Monstro"},
                        new Alternativa {Correta = false, Descricao = "Gorila"},
                        new Alternativa {Correta = false, Descricao = "Príncipe"},
                        new Alternativa { Correta = false, Descricao = "Sapo" },
                    }
                },
                new Pergunta
                {
                    Id = 11,
                    Enunciado = "O que era Frankenstein, de Mary Shelley?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = true, Descricao = "Monstro"},
                        new Alternativa {Correta = false, Descricao = "Gorila"},
                        new Alternativa {Correta = false, Descricao = "Príncipe"},
                        new Alternativa { Correta = false, Descricao = "Sapo" },
                    }
                },
                new Pergunta
                {
                    Id = 12,
                    Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Virgem"},
                        new Alternativa {Correta = false, Descricao = "Aquário"},
                        new Alternativa {Correta = true, Descricao = "Capricórnio"},
                        new Alternativa { Correta = false, Descricao = "Áries" },
                    }
                },
                new Pergunta
                {
                    Id = 13,
                    Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Harrison Ford"},
                        new Alternativa {Correta = false, Descricao = "Gerald Ford"},
                        new Alternativa {Correta = true, Descricao = "Henry Ford"},
                        new Alternativa { Correta = false, Descricao = "Anna Ford" },
                    }
                },
                new Pergunta
                {
                    Id = 14,
                    Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Preta"},
                        new Alternativa {Correta = false, Descricao = "Vermelha"},
                        new Alternativa {Correta = true, Descricao = "Azul"},
                        new Alternativa { Correta = false, Descricao = "Verde" },
                    }
                },
                new Pergunta
                {
                    Id = 15,
                    Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Preta"},
                        new Alternativa {Correta = false, Descricao = "Vermelha"},
                        new Alternativa {Correta = true, Descricao = "Azul"},
                        new Alternativa { Correta = false, Descricao = "Verde" },
                    }
                },
                new Pergunta
                {
                    Id = 16,
                    Enunciado = "A água ferve a quantos graus centígrados?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "200"},
                        new Alternativa {Correta = true, Descricao = "100"},
                        new Alternativa {Correta = false, Descricao = "170"},
                        new Alternativa { Correta = false, Descricao = "220" },
                    }
                },
                new Pergunta
                {
                    Id = 17,
                    Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "21 de abril"},
                        new Alternativa {Correta = false, Descricao = "12 de outubro"},
                        new Alternativa {Correta = true, Descricao = "7 de setembro"},
                        new Alternativa { Correta = false, Descricao = "25 de dezembro" },
                    }
                },
                new Pergunta
                {
                    Id = 18,
                    Enunciado = "Qual lugar é também chamadode Santa Sé?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Veneza"},
                        new Alternativa {Correta = false, Descricao = "Vitória"},
                        new Alternativa {Correta = false, Descricao = "Vancouver"},
                        new Alternativa { Correta = true, Descricao = "Vaticano" },
                    }
                },
                new Pergunta
                {
                    Id = 19,
                    Enunciado = "Quem tem por lema a frase: “Sempre alerta”?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = false, Descricao = "Médicos"},
                        new Alternativa {Correta = true, Descricao = "Escoteiros"},
                        new Alternativa {Correta = false, Descricao = "Bombeiros"},
                        new Alternativa { Correta = false, Descricao = "Policiais" },
                    }
                },
                new Pergunta
                {
                    Id = 20,
                    Enunciado = "Quem foi o grande amor de Julieta?",
                    Alternativa = new()
                    {
                        new Alternativa {Correta = true, Descricao = "Romeu"},
                        new Alternativa {Correta = false, Descricao = "Orfeu"},
                        new Alternativa {Correta = false, Descricao = "Hamlet"},
                        new Alternativa { Correta = false, Descricao = "Iago" },
                    }
                }
            };

        static List<Pergunta> perguntas_medias = new()
            {
                new Pergunta
                {
                    Id = 21,
                    Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "6" },
                        new Alternativa { Correta = false, Descricao = "8" },
                        new Alternativa { Correta = false, Descricao = "10" },
                        new Alternativa { Correta = true, Descricao = "12" },
                    }
                },
                new Pergunta
                {
                    Id = 22,
                    Enunciado = "Qual é o país do tango?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Uruguai" },
                        new Alternativa { Correta = true, Descricao = "Argentina" },
                        new Alternativa { Correta = false, Descricao = "Paraguai" },
                        new Alternativa { Correta = false, Descricao = "Espanha" },
                    }
                },
                new Pergunta
                {
                    Id = 23,
                    Enunciado = "Que imperador pôs fogo em Roma?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Trajano" },
                        new Alternativa { Correta = true, Descricao = "Nero" },
                        new Alternativa { Correta = false, Descricao = "Brutus" },
                        new Alternativa { Correta = false, Descricao = "Calígula" },
                    }
                },
                new Pergunta
                {
                    Id = 24,
                    Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Japão" },
                        new Alternativa { Correta = true, Descricao = "México" },
                        new Alternativa { Correta = false, Descricao = "Itália" },
                        new Alternativa { Correta = false, Descricao = "Estados Unidos" },
                    }
                },
                new Pergunta
                {
                    Id = 25,
                    Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Milanense" },
                        new Alternativa { Correta = false, Descricao = "Milanoso" },
                        new Alternativa { Correta = false, Descricao = "Milista" },
                        new Alternativa { Correta = true, Descricao = "Milanês" },
                    }
                },
                new Pergunta
                {
                    Id = 26,
                    Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Carpinteiro" },
                        new Alternativa { Correta = false, Descricao = "Relojoeiro" },
                        new Alternativa { Correta = false, Descricao = "Confeiteiro" },
                        new Alternativa { Correta = false, Descricao = "Bombeiro" },
                    }
                },
                new Pergunta
                {
                    Id = 27,
                    Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Morumbi" },
                        new Alternativa { Correta = false, Descricao = "Pacaembu" },
                        new Alternativa { Correta = true, Descricao = "Maracanã" },
                        new Alternativa { Correta = false, Descricao = "Mineirão" },
                    }
                },
                new Pergunta
                {
                    Id = 28,
                    Enunciado = "O que é um oboé?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Vulcão" },
                        new Alternativa { Correta = false, Descricao = "Comida" },
                        new Alternativa { Correta = true, Descricao = "Instrumento Musical" },
                        new Alternativa { Correta = false, Descricao = "Tribo Indígena" },
                    }
                },
                new Pergunta
                {
                    Id = 29,
                    Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Camicases" },
                        new Alternativa { Correta = false, Descricao = "Sashimis" },
                        new Alternativa { Correta = false, Descricao = "Haraquiris" },
                        new Alternativa { Correta = false, Descricao = "Sumôs" },
                    }
                },
                new Pergunta
                {
                    Id = 30,
                    Enunciado = "O que é gôndola?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Embarcação" },
                        new Alternativa { Correta = false, Descricao = "Brinquedo" },
                        new Alternativa { Correta = false, Descricao = "Música" },
                        new Alternativa { Correta = false, Descricao = "Símbolo" },
                    }
                },
                new Pergunta
                {
                    Id = 31,
                    Enunciado = "Sashimi é um prato originário de qual país?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Japão" },
                        new Alternativa { Correta = false, Descricao = "China" },
                        new Alternativa { Correta = false, Descricao = "Índia" },
                        new Alternativa { Correta = false, Descricao = "Indonésia" },
                    }
                },
                new Pergunta
                {
                    Id = 32,
                    Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Primeira Dama" },
                        new Alternativa { Correta = false, Descricao = "Dona-Prima" },
                        new Alternativa { Correta = true, Descricao = "Prima-Dona" },
                        new Alternativa { Correta = false, Descricao = "Obra-Prima" },
                    }
                },
                new Pergunta
                {
                    Id = 33,
                    Enunciado = "Peroba é uma espécie de?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Inseto" },
                        new Alternativa { Correta = true, Descricao = "Árvore" },
                        new Alternativa { Correta = false, Descricao = "Verme" },
                        new Alternativa { Correta = false, Descricao = "Verdura" },
                    }
                },
                new Pergunta
                {
                    Id = 34,
                    Enunciado = "O alpinismo é praticado em que lugar?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Mar" },
                        new Alternativa { Correta = true, Descricao = "Montanha" },
                        new Alternativa { Correta = false, Descricao = "Rio" },
                        new Alternativa { Correta = false, Descricao = "Praia" },
                    }
                },
                new Pergunta
                {
                    Id = 35,
                    Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Paris" },
                        new Alternativa { Correta = false, Descricao = "Copenhague" },
                        new Alternativa { Correta = true, Descricao = "Roma" },
                        new Alternativa { Correta = false, Descricao = "Londres" },
                    }
                },
                new Pergunta
                {
                    Id = 36,
                    Enunciado = "Qual é o ponto mais alto da Terra?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Everest" },
                        new Alternativa { Correta = false, Descricao = "Monte Sinai" },
                        new Alternativa { Correta = false, Descricao = "Monte Castelo" },
                        new Alternativa { Correta = false, Descricao = "Mont Blanc" },
                    }
                },
                new Pergunta
                {
                    Id = 37,
                    Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Tâmisa" },
                        new Alternativa { Correta = false, Descricao = "Sena" },
                        new Alternativa { Correta = false, Descricao = "Reno" },
                        new Alternativa { Correta = false, Descricao = "Aube" },
                    }
                },
                new Pergunta
                {
                    Id = 38,
                    Enunciado = "Qual é a raça do personagem principal do filme “Beethoven”?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Fila" },
                        new Alternativa { Correta = false, Descricao = "Pastor Alemão" },
                        new Alternativa { Correta = true, Descricao = "Poodle" },
                        new Alternativa { Correta = false, Descricao = "São-Bernardo" },
                    }
                },
                new Pergunta
                {
                    Id = 39,
                    Enunciado = "Quem foi eleito presidente da África do Sul em 1994?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Nelson Piquet" },
                        new Alternativa { Correta = true, Descricao = "Nelson Mandela" },
                        new Alternativa { Correta = false, Descricao = "Nelson Med" },
                        new Alternativa { Correta = false, Descricao = "Jhon Nelson" },
                    }
                },
                new Pergunta
                {
                    Id = 40,
                    Enunciado = "Qual cantor ficou conhecido como “O rei da voz”?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Orlando Silva" },
                        new Alternativa { Correta = false, Descricao = "Vicente Celestino" },
                        new Alternativa { Correta = true, Descricao = "Francisco Alves" },
                        new Alternativa { Correta = false, Descricao = "Carlos Galhardo" },
                    }
                }
            };

        static List<Pergunta> perguntas_dificeis = new()
            {
                new Pergunta
                {
                    Id = 41,
                    Enunciado = "Em qual espécie o macho choca os ovos e a fêmea procura alimento?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Andorinha" },
                        new Alternativa { Correta = false, Descricao = "Pato Selvagem" },
                        new Alternativa { Correta = true, Descricao = "Pinguim" },
                        new Alternativa { Correta = false, Descricao = "Marreco" },
                    }
                },
                new Pergunta
                {
                    Id = 42,
                    Enunciado = "Em qual país está localizado o “Muro das lamentações”?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Alemanha" },
                        new Alternativa { Correta = false, Descricao = "Brasil" },
                        new Alternativa { Correta = false, Descricao = "Venezuela" },
                        new Alternativa { Correta = true, Descricao = "Israel" },
                    }
                },
                new Pergunta
                {
                    Id = 43,
                    Enunciado = "Qual desses países não fica na Ásia?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Paquistão" },
                        new Alternativa { Correta = false, Descricao = "Japão" },
                        new Alternativa { Correta = false, Descricao = "Tailândia" },
                        new Alternativa { Correta = true, Descricao = "Egito" },
                    }
                },
                new Pergunta
                {
                    Id = 44,
                    Enunciado = "Qual desses astros de filmes de ação é belga?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Arnold Schwarzenegger" },
                        new Alternativa { Correta = false, Descricao = "Sylvester Stallone" },
                        new Alternativa { Correta = false, Descricao = "Steven Seagal" },
                        new Alternativa { Correta = true, Descricao = "Jean Claude Van Damme" },
                    }
                },
                new Pergunta
                {
                    Id = 45,
                    Enunciado = "Onde foi conduzida a vitória das forças aliadas na Segunda Guerra Mundial?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Cannes" },
                        new Alternativa { Correta = true, Descricao = "Normandia" },
                        new Alternativa { Correta = false, Descricao = "Capri" },
                        new Alternativa { Correta = false, Descricao = "Marselha" },
                    }
                },
                new Pergunta
                {
                    Id = 46,
                    Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Polônia" },
                        new Alternativa { Correta = false, Descricao = "França" },
                        new Alternativa { Correta = false, Descricao = "Itália" },
                        new Alternativa { Correta = true, Descricao = "Holanda" },
                    }
                },
                new Pergunta
                {
                    Id = 47,
                    Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Delta" },
                        new Alternativa { Correta = false, Descricao = "Beta" },
                        new Alternativa { Correta = true, Descricao = "Alfa" },
                        new Alternativa { Correta = false, Descricao = "Gama" },
                    }
                },
                new Pergunta
                {
                    Id = 48,
                    Enunciado = "Qual presidente brasileiro instituiu o AI-5?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Costa e Silva" },
                        new Alternativa { Correta = false, Descricao = "Ernesto Geisel" },
                        new Alternativa { Correta = false, Descricao = "João Figueiredo" },
                        new Alternativa { Correta = false, Descricao = "Itamar Franco" },
                    }
                },
                new Pergunta
                {
                    Id = 49,
                    Enunciado = "O que significa literalmente Perestroika?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Conversão" },
                        new Alternativa { Correta = false, Descricao = "Involução" },
                        new Alternativa { Correta = true, Descricao = "Reestruturação" },
                        new Alternativa { Correta = false, Descricao = "Regressão" },
                    }
                },
                new Pergunta
                {
                    Id = 50,
                    Enunciado = "Qual desses quatro pesos é o mais leve?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "10 onças" },
                        new Alternativa { Correta = false, Descricao = "10 gramas " },
                        new Alternativa { Correta = false, Descricao = "10 quilos" },
                        new Alternativa { Correta = false, Descricao = "10 libras" },
                    }
                },
                new Pergunta
                {
                    Id = 51,
                    Enunciado = "Brahma é o deus de que religião?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Hinduísmo" },
                        new Alternativa { Correta = false, Descricao = "Xintoísmo" },
                        new Alternativa { Correta = false, Descricao = "Budismo" },
                        new Alternativa { Correta = false, Descricao = "Islamismo" },
                    }
                },
                new Pergunta
                {
                    Id = 52,
                    Enunciado = "Os nazistas foram julgados em:",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Berlim" },
                        new Alternativa { Correta = true, Descricao = "Nurembergue" },
                        new Alternativa { Correta = false, Descricao = "Munique" },
                        new Alternativa { Correta = false, Descricao = "Paris" },
                    }
                },
                new Pergunta
                {
                    Id = 53,
                    Enunciado = "Que ramo da pecuária ocupa-se de bodes e cabras?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Asinino" },
                        new Alternativa { Correta = true, Descricao = "Caprino" },
                        new Alternativa { Correta = false, Descricao = "Bufalino" },
                        new Alternativa { Correta = false, Descricao = "Muar" },
                    }
                },
                new Pergunta
                {
                    Id = 54,
                    Enunciado = "Qual oceano tem o maior volume de água?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Atlântico" },
                        new Alternativa { Correta = true, Descricao = "Pacífico" },
                        new Alternativa { Correta = false, Descricao = "Índico" },
                        new Alternativa { Correta = false, Descricao = "Ártico" },
                    }
                },
                new Pergunta
                {
                    Id = 55,
                    Enunciado = "Qual foi o último presidente militar do Brasil?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Fernando Collor" },
                        new Alternativa { Correta = true, Descricao = "João Figueiredo" },
                        new Alternativa { Correta = false, Descricao = "Tancredo Neves" },
                        new Alternativa { Correta = false, Descricao = "João Goulart" },
                    }
                },
                new Pergunta
                {
                    Id = 56,
                    Enunciado = "Que conflito ideológico envolveu os EUA e a União Soviética?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Guerra Fria" },
                        new Alternativa { Correta = false, Descricao = "Guerra do Vietnã" },
                        new Alternativa { Correta = false, Descricao = "Guerra nas estrelas" },
                        new Alternativa { Correta = false, Descricao = "Guerra da Coréia" },
                    }
                },
                new Pergunta
                {
                    Id = 57,
                    Enunciado = "O trapézio é um músculo que está situado:",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "No pescoço" },
                        new Alternativa { Correta = false, Descricao = "No ombro" },
                        new Alternativa { Correta = false, Descricao = "Na cabeça" },
                        new Alternativa { Correta = false, Descricao = "No braço" },
                    }
                },
                new Pergunta
                {
                    Id = 58,
                    Enunciado = "Quem escreveu o livro “A sangue frio” em 1966?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = true, Descricao = "Truman Capote" },
                        new Alternativa { Correta = false, Descricao = "Henry James" },
                        new Alternativa { Correta = false, Descricao = "John Steinbeck" },
                        new Alternativa { Correta = false, Descricao = "Toni Morrison" },
                    }
                },
                new Pergunta
                {
                    Id = 59,
                    Enunciado = "Quem escreveu “Ulisses” em 1922?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Ernest Hemingway" },
                        new Alternativa { Correta = false, Descricao = "Marcel Proust" },
                        new Alternativa { Correta = false, Descricao = "T. S. Elliot" },
                        new Alternativa { Correta = true, Descricao = "James Joyce" },
                    }
                },
                new Pergunta
                {
                    Id = 60,
                    Enunciado = "Qual o símbolo químico do radônio?",
                    Alternativa = new()
                    {
                        new Alternativa { Correta = false, Descricao = "Rr" },
                        new Alternativa { Correta = false, Descricao = "Rd" },
                        new Alternativa { Correta = true, Descricao = "Rn" },
                        new Alternativa { Correta = false, Descricao = "Ro" },
                    }
                },
            };

        public static Pergunta getRandomPerguntaFacil()
        {
            Random r = new Random();

            int sorteado = r.Next(1, perguntas_faceis.Count);

            return perguntas_faceis[sorteado];
        }

        public static Pergunta getRandomPerguntaMedia()
        {
            Random r = new Random();

            int sorteado = r.Next(21, perguntas_medias.Count);

            return perguntas_medias[sorteado];
        }

        public static Pergunta getRandomPerguntaDificil()
        {
            Random r = new Random();
            int sorteado = r.Next(41, perguntas_dificeis.Count);
            return perguntas_dificeis[sorteado];
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
