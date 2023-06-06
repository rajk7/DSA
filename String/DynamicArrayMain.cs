using System;
using System.Collections;
using System.Collections.Generic;

public class DynamicArrayMain
{
    public static void Main(string[] args)
    {

        DynamicArray dynamicArray = new DynamicArray();

        dynamicArray.Add("A");
        dynamicArray.Add("B");
        dynamicArray.Add("C");
        dynamicArray.Add("D");
        dynamicArray.Add("E");


        Console.WriteLine(dynamicArray.Get(0));
        dynamicArray.Insert(0, "X");
        dynamicArray.Delete("A");
        Console.WriteLine(dynamicArray.Search("C"));

        Console.WriteLine(dynamicArray.toString());

        Console.WriteLine("size: " + dynamicArray.size);
        Console.WriteLine("capacity: " + dynamicArray.capacity);
        Console.WriteLine("empty: " + dynamicArray.IsEmpty());
    }

    public class DynamicArray
    {

        public int size;
        public int capacity = 10;
        Object[] array;

        public DynamicArray()
        {
            this.array = new Object[capacity];
        }
        public DynamicArray(int capacity)
        {
            this.capacity = capacity;
            this.array = new Object[capacity];
        }

        public Object Get(int index)
        {
            return array[index];
        }

        public void Add(Object data)
        {
            if (size >= capacity)
            {
                Grow();
            }
            array[size] = data;
            size++;
        }

        public void Insert(int index, Object data)
        {
            if (size >= capacity)
            {
                Grow();
            }
            for (int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = data;
            size++;
        }

        public void Delete(Object data)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == data)
                {
                    for (int j = 0; j < (size - i - 1); j++)
                    {
                        array[i + j] = array[i + j + 1];
                    }
                    array[size - 1] = null;
                    size--;
                    if (size <= (int)(capacity / 3))
                    {
                        Shrink();
                    }
                    break;
                }
            }
        }

        public int Search(Object data)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == data)
                {
                    return i;
                }
            }
            return -1;
        }

        private void Grow()
        {
            int newCapacity = (int)(capacity * 2);
            Object[] newArray = new Object[newCapacity];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            capacity = newCapacity;
            array = newArray;
        }

        private void Shrink()
        {
            int newCapacity = (int)(capacity / 2);
            Object[] newArray = new Object[newCapacity];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            capacity = newCapacity;
            array = newArray;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public string toString()
        {
            string str = "";

            for (int i = 0; i < capacity; i++)
            {
                str += array[i] + ", ";
            }
            if (str != "")
            {
                str = "[" + str.Substring(0, str.Length - 2) + "]";
            }
            else
            {
                str = "[]";
            }
            return str;
        }
    }
}
