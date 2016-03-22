namespace _3.GenericList
{
    using System;
    using System.Linq;
    using System.Text;
    using Attributes;

    [Version(354, 141356)]
    public class CustomList<T>
        where T : IComparable<T>
    {
        private T[] array;
        private int index;
        private bool[] arrayHasElements;
        private const int DefaultCapacity = 16;

        public CustomList(int capacity = DefaultCapacity)
        {
            this.array = new T[capacity];
            this.arrayHasElements = new bool[capacity];
            this.index = 0;
        }

        public void Add(T element)
        {
            if (this.index == this.array.Length)
            {
                Resize();
            }
            this.array[this.index] = element;
            this.arrayHasElements[this.index] = true;
            this.index++;
        }
        public T Access(int indexToAccess)
        {
            CheckIfListIsEmpty();
            CheckIfInside(indexToAccess);
            return this.array[indexToAccess];
        }
        public void Remove(int indexToRemove)
        {
            CheckIfListIsEmpty();
            CheckIfInside(indexToRemove);
            if (this.index == this.array.Length)
            {
                Resize();
            }
            T[] newArray = new T[this.array.Length];
            Array.Copy(this.array,newArray,indexToRemove);
            Array.Copy(this.array, indexToRemove + 1, newArray, indexToRemove, this.index - indexToRemove);
            this.array = newArray;
            this.index--;
            this.arrayHasElements[this.index] = false;
        }
        public void Insert(int indexToInsertAt, T elementToInsert)
        {
            CheckIfInside(indexToInsertAt);
            T[] newArray = new T[this.array.Length+1];
            Array.Copy(this.array, newArray, indexToInsertAt);
            newArray[indexToInsertAt] = elementToInsert;
            Array.Copy(this.array, indexToInsertAt, newArray, indexToInsertAt+1, this.index - indexToInsertAt);
            this.array = newArray;
            this.arrayHasElements[this.index] = true;
            this.index++;         
        }
        public void Clear()
        {
            T[] newArray = new T[DefaultCapacity];
            this.array = newArray;
            bool[] newBoolArray = new bool[DefaultCapacity];
            this.arrayHasElements = newBoolArray;
            this.index = 0;
        }
        public int IndexOf(T element)
        {
            CheckIfListIsEmpty();
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Contains(T element)
        {
            if (this.array.Contains(element))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T Min()
        {
            CheckIfListIsEmpty();
            T min = this.array[0];
            for (int i = 1; this.arrayHasElements[i]; i++)
            {
                if (this.array[i].CompareTo(min) <= 0)
                {
                    min = this.array[i];
                }
            }
            return min;
        }
        public T Max()
        {
            CheckIfListIsEmpty();
            T max = this.array[0];
            for (int i = 1; this.arrayHasElements[i]; i++)
            {
                if (this.array[i].CompareTo(max) >= 0)
                {
                    max = this.array[i];
                }
            }
            return max;
        }
        public override string ToString()
        {
            if (this.arrayHasElements.Length != this.array.Length)
            {
                bool[] newBoolArray = new bool[this.array.Length];
                for (int i = 0; i < this.arrayHasElements.Length; i++)
                {
                    newBoolArray[i] = arrayHasElements[i];
                }
                this.arrayHasElements = newBoolArray;
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.array.Length; i++)
            {
                if (arrayHasElements[i])
                {
                    result.AppendFormat("Element {0}: {1}\n",i +1,this.array[i]);
                }
            }
            return result.ToString();
        }
        public string Verstion()
        {
            string versionNum = string.Empty;
            Type type = typeof (CustomList<T>);
            var allAttributes = type.GetCustomAttributes(false);
            foreach (var atr in allAttributes)
            {
                var currentAttribute = atr as VersionAttribute;
                if (currentAttribute != null)
                {
                    var version = currentAttribute;
                    versionNum = $"CustomList<T> version {version.Major}.{version.Minor}";
                }
            }

            return versionNum;
        }
        private void Resize()
        {
            T[] newArray = new T[this.index * 2];
            bool[] newBoolArray = new bool[newArray.Length +1];
            for (int i = 0; i < this.arrayHasElements.Length; i++)
            {
                newBoolArray[i] = this.arrayHasElements[i];
            }
            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }
            this.arrayHasElements = newBoolArray;
            this.array = newArray;            
        }
        private void CheckIfInside(int indexToAccess)
        {
            if (indexToAccess >= this.array.Length
               || indexToAccess < 0
               || this.arrayHasElements[indexToAccess] == false)
            {
                throw new InvalidOperationException("The index you've entered doesn't contain an element");
            }
        }
        private void CheckIfListIsEmpty()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
        }
    }
}
