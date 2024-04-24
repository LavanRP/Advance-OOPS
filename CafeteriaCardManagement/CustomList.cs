
using System.Collections.Generic;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// CustomList class is used like list for storing data in array<see cref="CustomList"/>
    /// </summary>
    public class CustomList<Type>
    {
        /// <summary>
        /// _count is a private field used to store the no of values in the _array<see cref="CustomList"/>
        /// </summary>
        private int _count;
        /// <summary>
        /// _capacity is a private field used to store the size of in the _array<see cref="CustomList"/>
        /// </summary>
        private int _capacity;
        /// <summary>
        /// _array is a private field used to store the values<see cref="CustomList"/>
        /// </summary>
        private Type[] _array;
        /// <summary>
        /// Count is a public property used to store count of element present in the array.<see cref="CustomList"/>
        /// </summary>
        public int Count { get { return _count; } }
        /// <summary>
        /// Capacity is a public property used to store size of the array.<see cref="CustomList"/>
        /// </summary>
        public int Capacity { get { return _capacity; } }
        /// <summary>
        /// this is a public prorerty which returns the value by getting the index value <see cref="CustomList"/>
        /// </summary>
        public Type this[int index] { get { return _array[index]; } }
        
        /// <summary>
        /// it is no argumnet constructor used when the user does not knoe the exact size of the array <see cref="CustomList"/>
        /// </summary> 
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// it is argument constructor which used when the user knows the exact size of the array <see cref="CustomList"/>
        /// </summary>
        /// <param name="size">size stores the value in _capacity</param>
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// Add is a public method which is used to add value to the array <see cref="CustomList"/>
        /// </summary>
        /// <param name="element">element is a value which is added in the array</param>
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }
        /// <summary>
        /// AddRange is a public method whic is used to add a range of values in the array <see cref="CustomList"/>
        /// </summary>
        /// <param name="elements">elements is a object which is added to current array</param>
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _capacity + _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < elements.Count + _count; i++)
            {
                temp[i] = elements[k];
                k++;
            }
            _array = temp;
            _count = _count + elements.Count;
        }
        /// <summary>
        /// GrowSize is a public method which is called inside Add method.it is used to increase the size of the array <see cref="CustomList"/>
        /// </summary>
        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        /// <summary>
        /// Contains is a public method which used to check weather the element present in array and returns bool value based on the result <see cref="CustomList"/>
        /// </summary>
        /// <param name="element">element is a value thet need to be searched in the array</param>
        /// <returns></returns>
        public bool Contains(Type element)
        {
            bool res = false;
            foreach (Type i in _array)
            {
                if (i.Equals(element))
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        /// <summary>
        /// IndexOf is a public method which returns the index of the given element in the array <see cref="CustomList"/>
        /// </summary>
        /// <param name="element">element is a value which need to find its index value in the array</param>
        /// <returns>Returns the index of the element in the array</returns> 
        public int IndexOf(Type element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (element.Equals(_array[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        /// <summary>
        /// Insert is a public method which is used to insert an element in a specific index of the array <see cref="CustomList"/>
        /// </summary>
        /// <param name="position">position is the index value where the element need to be inserted</param>
        /// <param name="element">element is value which we need to insert in the array</param>
        public void Insert(int position, Type element)
        {
            _capacity = _capacity + 1;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i <= _count; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                }
                else if (i == position)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }

            }
            _count++;
            _array = temp;
        }
        /// <summary>
        /// RemoveAt is a public method which is used to remove a element by its index number from the list <see cref="CustomList"/>
        /// </summary>
        /// <param name="position">position is the index value</param>
        public void RemoveAt(int position)
        {
            for (int i = 0; i < _count - 1; i++)
            {
                if (i >= position)
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
        }
        /// <summary>
        /// Remove is public method used to remove an element by finding its index value usig IndexOf method <see cref="CustomList"/>
        /// </summary>
        /// <param name="element">element that need to be removed</param>
        /// <returns>return true if element is removed else return false</returns>
        public bool Remove(Type element)
        {
            int position = IndexOf(element);
            if (position >= 0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sort is a public method which is used to sort the array <see cref="CustomList"/>
        /// </summary>
        public void Sort()
        {
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = 0; j < _count - 1; j++)
                {
                    if (Comparer<Type>.Default.Compare(_array[j], _array[j + 1]) < 0)
                    {
                        Type temp = _array[j + 1];
                        _array[j + 1] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }
    }
}