using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Konstantin
{
         class PrimeNumbers : ISimpleNumbers
         {
            private int limit = 0;
            public PrimeNumbers(int top) { this.limit = top; }

            private class PMSequence : IEnumerator
            {
                private PrimeNumbers instance;
                private int currentNumber = 0;

                public PMSequence(PrimeNumbers instance) { this.instance = instance; }

                public object Current
                {
                    get { throw new NotImplementedException(); }
                }

                public bool MoveNext()
                {
                    throw new NotImplementedException();
                }

                public void Reset()
                {
                    throw new NotImplementedException();
                }
            }
        }
}
