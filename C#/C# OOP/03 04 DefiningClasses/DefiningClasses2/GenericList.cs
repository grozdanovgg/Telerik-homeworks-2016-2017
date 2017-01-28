using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    class GenericList<T>
       where T : IComparable
    {
        //fields
        private int capacity;
        private T[] elements;
        //parameters
        public int Count { get; private set; }

        //constructor
        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.Count = 0;
            this.capacity = capacity;
        }

        //other methods

        public void Add(T item)
        {
            elements[this.Count] = item;
            this.Count++;
            if (this.Count == this.capacity)
            {
                ExdpandArray();
            }
        }

        public T ElementAtIndex(int index)
        {
            if ((index < 0) & (index > elements.Length))
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T result = elements[index];
                return result;
            }
        }

        public void Remove(int index)
        {
            if ((index < 0) & (index > elements.Length))
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                elements[index] = default(T);
            }
        }

        public void InsertAt(T element, int index)
        {
            if ((index < 0) & (index > elements.Length))
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                elements[index] = element;
            }
        }

        public void ClearList()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = default(T);
            }
        }

        public int IndexOf(T element)
        {
            int result = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                //Alternative solution
                //result = Array.IndexOf(elements, element);

                if (elements[i].Equals(element))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < elements.Length; i++)
            {
                output.Append(elements[i] + " ");
            }

            output.AppendLine();

            return output.ToString();
        }

        private void ExdpandArray()
        {
            var newElements = new T[2 * elements.Length];

            Array.Copy(elements, newElements, this.Count);

            this.elements = newElements;

            capacity *= 2;
        }

        public T Min()
        {
            T result = elements[1];
            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].CompareTo(result) == -1)
                {
                    result = elements[i];
                }
            }

            return result;
        }
        public T Max()
        {
            T result = elements[1];
            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].CompareTo(result) == 1)
                {
                    result = elements[i];
                }
            }

            return result; 
        }
    }
}
