using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Konstantin
{
    abstract class Number<T>
    {
        private T value;
        public Number() { }
        public Number(T val) { this.value = value; }
        public abstract T Add(T op1, T op2); 
    }
    class Int : Number<int>
    {
        
    }
}
