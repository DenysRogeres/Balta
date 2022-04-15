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

            foreach(var artigo in artigos) 
            {
                Console.WriteLine(artigo.Id);
                Console.WriteLine(artigo.Titulo);
                Console.WriteLine(artigo.Url);
                Console.WriteLine("--------------");
            }

        }
    }
}
