using System;
using System.Collections.Generic;
using System.Linq;
using List.Extensao;
using List.Models;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListName();
            //ListNumber();
            //ListPerson();
            ListPersonOrderBy();
        }
        static void ListPersonOrderBy()
        {
            var pessoas = new List<Pessoa>() {
                new Pessoa { Id = 90, Nome = "Paulo" },
                new Pessoa { Id = 56, Nome = "Andre" },
                new Pessoa { Id = 100, Nome = "Guilherme" },
                new Pessoa { Id = 77, Nome = "Gisele" },
                new Pessoa { Id = 10, Nome = "Maria" },
                null,
                null



            };
            ///Order By
            /*IEnumerable<Pessoa> pessoaOrdeneda = pessoas.OrderBy(pessoas => {
                if (pessoas == null)
                { 
                    return int.MaxValue;
                }
                return pessoas.Id;
            });*/

            ///Where
            var pessoaOrdeneda = pessoas
                .Where(pessoas => pessoas != null)
                .OrderBy(pessoas => pessoas.Id);

            foreach (var item in pessoaOrdeneda)
            {
                Console.WriteLine(item.Nome);
            }
        }
        static void ListPerson()
        {
            var pessoas = new List<Pessoa>() {
                new Pessoa { Id = 90, Nome = "Paulo" },
                new Pessoa { Id = 56, Nome = "Andre" },
                new Pessoa { Id = 100, Nome = "Guilherme" },

            };
            pessoas.Sort();
            foreach (var item in pessoas)
            {

                Console.WriteLine(item.Nome);
            }
        }
        static void ListNumber()
        {
            List<int> _listaInteiro = new List<int>();
            _listaInteiro.AddMany(1, 2, 5, 8, 6, 9);
            int[] _number = new int[5] { 1, 2, 9, 7, 4 };
            _listaInteiro.AddMany(_number);
            _listaInteiro.Sort();
            _listaInteiro.ShowItens();

        }
        static void ListName()
        {
            var _listaConvidados = new List<string>();
            _listaConvidados.AddManyGeneric("Paula", "Joana");
            var _name = new string[5] { "Cassia", "Andressa", "Julia", "Amanda", "Pedro" };
            _listaConvidados.AddManyGeneric(_name);
            _listaConvidados.Sort();
            _listaConvidados.ShowItensGeneric();

        }
    }
}
