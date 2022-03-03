using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public static class ListExtends
    {
        public static void AddMany(this List<int> list, params int[] values) {
            foreach (int item in values)
            {
                list.Add(item);
            }
            
        }
        public static void ShowItens(this List<int> list) {
            foreach (var item in list) {
                Console.WriteLine($"Imprimindo o valor do item {item}");
            }
        }
    }
}
