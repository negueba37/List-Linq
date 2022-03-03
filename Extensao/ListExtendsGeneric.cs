using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Extensao
{
    public static class ListExtends
    {
        public static void AddManyGeneric<T>(this List<T> list, params T[] values) {
            foreach (T item in values)
            {
                list.Add(item);
            }
            
        }
        public static void ShowItensGeneric<T>(this List<T> list) {
            foreach (T item in list) {
                Console.WriteLine($"Imprimindo o valor do item {item}");
            }
        }
    }
}
