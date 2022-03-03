using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Models
{
    class Pessoa:IComparable
    {
        public int Id{ get; set; }
        public string Nome { get; set; }



        public int CompareTo(object obj)
        {
            var objPessoa = obj as Pessoa;
            if (objPessoa == null)
                return -1;
            if (objPessoa.Id > Id)
                return -1;
            if (objPessoa.Id < Id)
                return 1;
            return 0;
        }
    }
}
