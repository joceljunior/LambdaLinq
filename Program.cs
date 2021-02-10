using System;
using System.Collections.Generic;

namespace LambdaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Cidades SaoPaulo = new Cidades();
            SaoPaulo.Nome = "Sao Paulo";

            Cidades RiodeJaneiro = new Cidades();
            RiodeJaneiro.Nome = "Rio de Jneiro";

            Cidades PortoAlegre = new Cidades();
            PortoAlegre.Nome = "Porto Alegre";

            Cidades Portao = new Cidades();
            Portao.Nome = "Portão";

            Cidades BeloHorizonte = new Cidades();
            BeloHorizonte.Nome = "Belo Horizonte";

            Cidades Salvador = new Cidades();
            Salvador.Nome = "Salvador";

            Cidades Curitiba = new Cidades();
            Curitiba.Nome = "Curitiba";

            Cidades Florianopolis = new Cidades();
            Florianopolis.Nome = "Florianopolis";

            List<string> cidades = new List<string>();

            cidades.Add(SaoPaulo.Nome);
            cidades.Add(RiodeJaneiro.Nome);
            cidades.Add(PortoAlegre.Nome);
            cidades.Add(Florianopolis.Nome);
            cidades.Add(Curitiba.Nome);
            cidades.Add(BeloHorizonte.Nome);
            cidades.Add(Salvador.Nome);
            cidades.Add(Portao.Nome);

            BuscaCidade buscador = new BuscaCidade(cidades);

           // string result = buscador.BuscaNormal("Belo ");
           // string result = buscador.BuscaLinq("Porto Alere");
            string result = buscador.BuscaLambda("Porto Alegre");


            //Console.WriteLine(result);
            //Console.ReadLine();

            // percorre o resultado da funcao e para cada x, mostra o resultado.
            //buscador.BuscaLinqLst("Sa").ForEach(x => Console.WriteLine(x)); 
            buscador.BuscaLambdaLst("Po").ForEach(x => Console.WriteLine(x)); 
            Console.ReadKey();

        }
        
    }
}
