using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// CustomeList give us the functionalit like list <see cref="CustomeList"/>
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class CustomeList<Type>: IEnumerable,IEnumerator
    {
        /// <summary>
        /// _count is private field used to store the count of the element present in array <see cref="CustomeList"/>
        /// </summary>
        private int _count;
        /// <summary>
        /// _capacity is private field used to store the capacity of the  array <see cref="CustomeList"/>
        /// </summary>
        private int _capacity;
        /// <summary>
        /// position is field used for giving position to for each array <see cref="CustomeList"/>
        /// </summary>
        int position = -1;
        /// <summary>
        /// _array is private field used to store element present <see cref="CustomeList"/>
        /// </summary>
        private Type[] _array;
        /// <summary>
        /// Count property is used to give the _count value <see cref="CustomeList"/>
        /// </summary>
        public int Count { get { return _count; } }
        /// <summary>
        /// Capacity property is used to give the _capacity value <see cref="CustomeList"/>
        /// </summary>
        public int Capacity { get { return _capacity; } }
        /// <summary>
        /// this property gives access for using index valu for the list<see cref="CustomeList"/>
        /// </summary>
        public Type this[int index] { get { return _array[index]; } set { _array[index] = value; } }
        /// <summary>
        /// this constructor is used when we dont know the exact size <see cref="CustomeList"/>
        /// </summary>
        public CustomeList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// this constructor is used when the user knows exact size of the list <see cref="CustomeList"/>
        /// </summary>
        /// <param name="size">gives the size of the list</param>
        public CustomeList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// Add is used to add an element in the list <see cref="CustomeList"/>
        /// </summary>
        /// <param name="element"></param>
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                Grow();
            }
            _array[_count] = element;
            _count++;
        }
        /// <summary>
        /// Grow is used to increase the capacity <see cref="CustomeList"/>
        /// </summary>
        public void Grow()
        {
            _capacity = _capacity * 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        /// <summary>
        /// AddRange is used to add the one list to another list  <see cref="CustomeList"/>
        /// </summary>
        /// <param name="elements">elements is a list here</param>
        public void AddRange(CustomeList<Type> elements)
        {
            _capacity = _capacity + elements.Capacity + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < elements._count + _count; i++)
            {
                temp[i] = elements[k];
                k++;
            }
            _count = _count + elements.Count;
            _array = temp;
        }
        /// <summary>
        /// this method gives access for foreach loop<see cref="CustomeList"/>
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        /// <summary>
        /// MoveNext method is to increase position<see cref="CustomeList"/>
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        /// <summary>
        /// Reset method is use to set the value of position to -1 after every foreach loop<see cref="CustomeList"/>
        /// </summary>
        public void Reset()
        {
            position = -1;
        }
        /// <summary>
        /// Current is property used to return the array value based on the position <see cref="CustomeList"/>
        /// </summary>
        public object Current { get { return _array[position]; } }
    }
}