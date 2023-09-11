using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class GenericNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public GenericNode<T> Next { get; set; }

        public GenericNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
