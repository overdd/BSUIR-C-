using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Laba_1_5.Task_5
{
    class ParametrizedClass<T>
    {
        T[] Elements { get; set; }
        int[] StartEnd { get; set; }

        public bool ReturnRandom = false;

        public ParametrizedClass(T[] elements, int[] startEnd)
        {
            this.StartEnd = startEnd;
            this.Elements = elements;
        }

        public IEnumerator GetEnumerator()
        {
            return this.ReturnRandom ? RandomEnumerator() : RegularEnumerator();
        }

        public IEnumerator RandomEnumerator()
        {
            Random rand = new Random();

            for (int i = StartEnd[1] - 1; i > StartEnd[0] - 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = Elements[j];
                Elements[j] = Elements[i];
                Elements[i] = tmp;
            }

            for (int i = StartEnd[0] - 1; i < StartEnd[1]; i++)
            {
                yield return Elements[i];
            }
        }

        public IEnumerator RegularEnumerator()
        {

            for (int i = StartEnd[0] - 1; i < StartEnd[1]; i++)
            {
                yield return Elements[i];
            }
        }

    }
}
