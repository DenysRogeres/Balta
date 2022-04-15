using System;
using Balta.ConteudoContext;

namespace Balta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var artigos = new List<Artigo>();
            artigos.Add(new Artigo("Artigo sobre .NET", "dotnet.com.br"));
            artigos.Add(new Artigo("Artigo sobre Javascript", "javascript.com.br"));

            // foreach(var artigo in artigos) 
            // {
            //     Console.WriteLine(artigo.Id);
            //     Console.WriteLine(artigo.Titulo);
            //     Console.WriteLine(artigo.Url);
            // }

            var cursoBackEnd = new List<Curso>();

            var cursoCshartp = new Curso("Curso de C#", "csharpt.com");
            var cursoDotNet = new Curso("Curso de .NET", "dotnet.com");
            var cursoAspNet = new Curso("Curso de ASP.NET", "aspnet.com");

            cursoBackEnd.Add(cursoCshartp);
            cursoBackEnd.Add(cursoDotNet);
            cursoBackEnd.Add(cursoAspNet);

            var carreiras = new List<Carreira>();
            var carreiraDotNet = new Carreira("Carreira de especialista em .NET", "carreira.com");

            var carreiraItem1 = new CarreiraItem(1,"Comece por aqui", "", null);
            var carreiraItem2 = new CarreiraItem(2,"Depois por aqui", "", null);
            var carreiraItem3 = new CarreiraItem(3,"Por último por aqui", "", null);

            carreiras.Add(carreiraDotNet);

            carreiraDotNet.Itens.Add(carreiraItem2);
            carreiraDotNet.Itens.Add(carreiraItem1);
            carreiraDotNet.Itens.Add(carreiraItem3);

            foreach(var carreira in carreiras) 
            {
                Console.WriteLine(carreira.Titulo);
                foreach(var item in carreira.Itens.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Titulo}");
                }
            }



        }
    }
}
