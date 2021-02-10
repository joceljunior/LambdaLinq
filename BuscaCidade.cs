using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaLinq
{
    class BuscaCidade
    {
        private List<string> Cidades { get; }
        public BuscaCidade(List<string> lst)
        {
            Cidades = lst;
        }

        /// <summary>
        /// Busca simples com foreach
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns>retorna uma string</returns>
        public string BuscaNormal(string cidade)
        {
            foreach (string item in Cidades)
            {
                if (item.Equals(cidade))
                    return item;
            }

            return "Termo não encontrado";
        }

        /// <summary>
        /// Item in cidades é o mesmo funcionamento do foreach, faz um where e seleciona o retorno.
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns> Try Cath para caso da consulta retornar null</returns>
        public string BuscaLinq(string cidade)
        {
            try
            {
                return (from item in Cidades where item.Equals(cidade) select item).First();
            }
            catch
            {
                return "Termo não encontrado";
            }

        }

        public List<string> BuscaLinqLst(string termo)
        {
            try
            {
                return (from item in Cidades where item.Contains(termo) select item).ToList();
            }
            catch
            {
                Cidades.Add("Termo não encontrado");

                return Cidades;

            }
        }

        /// <summary>
        /// x seria cada item da lista
        /// </summary>
        /// <returns>retorna uma strin</returns>
        public string BuscaLambda(string cidade)
        {
            return Cidades.First(x => x.Equals(cidade));
        }

        public List<string> BuscaLambdaLst(string termo)
        {
            return Cidades.Where(x => x.Contains(termo)).ToList();
        }
    }
}
