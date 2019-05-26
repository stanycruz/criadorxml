using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CriadorXml
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Pessoa> pessoas = new Pessoa[] 
            {
                new Pessoa() { Nome = "Sônia Mariana Assunção", Idade = 32 },
                new Pessoa() { Nome = "Renan Murilo Vieira", Idade = 41 },
                new Pessoa() { Nome = "Anthony Felipe Cavalcanti", Idade = 44 },
                new Pessoa() { Nome = "Daiane Mirella Lavínia Nunes", Idade = 65 },
                new Pessoa() { Nome = "Gabrielly Rayssa dos Santos", Idade = 44 },
                new Pessoa() { Nome = "Mário Enzo Osvaldo Peixoto", Idade = 29 },
                new Pessoa() { Nome = "Alice Isabel Sophia Jesus", Idade = 74 },
                new Pessoa() { Nome = "Lucca Miguel Barros", Idade = 56 },
                new Pessoa() { Nome = "Theo Samuel de Paula", Idade = 59 },
                new Pessoa() { Nome = "Antônia Aparecida da Luz", Idade = 46 }
            };

            var i = 1;

            var xml = new XDocument(
                    new XComment("Aqui fica um comentário qualquer..."),
                    new XElement("Pessoas",
                    new XAttribute("total", pessoas.ToList().Count()),
                        pessoas.Select(p => new XElement("Pessoa",
                                            new XAttribute("id", i++),
                                            new XElement("Nome", p.Nome),
                                            new XElement("Idade", p.Idade)))));

            xml.Save(Console.Out);

            Console.ReadKey();
        }

        private class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }
    }
}
