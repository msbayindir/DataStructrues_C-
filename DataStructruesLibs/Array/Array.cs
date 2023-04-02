using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace DataStructruesLibs.Array
{
	public class Array<T>:IEnumerable<T>,ICloneable
	{
        private T[] inneArray;
        public int Capacity => inneArray.Length;
        public int  Count { get; private set; }

        public Array()
		{
            inneArray = new T[2];
            Count = 0;
		}
        public Array(params T[]initial)
        {
            inneArray = new T[initial.Length];
            Count = 0;

            foreach (var item in initial) Add(item);
        }
        public Array(IEnumerable<T> collections)
        {
            inneArray = new T[collections.ToArray().Length];
            Count = 0;
            foreach (var item in collections)
            {
                Add(item);
            }

        }

        public void Add(T value)
        {
            if (Capacity == Count) DoubleArray();
           

            inneArray[Count] = value;
            Count++;
        }
        public T Remove()
        {
            if (Count == 0) throw new Exception("Silinecek İtem Yok");
            //inneArray.Length / 4 == Count
            if (Count * 2 == Capacity)
            {
                HalfArray();
            }


            var temp = inneArray[Count - 1];
            if (Count>0)
            Count--;

            return temp;
        }
        private void HalfArray()
        {
            if (inneArray.Length > 2)
            {
                var tempp = new T[inneArray.Length / 2];
                System.Array.Copy(inneArray, tempp, Count);
                inneArray = tempp;
            }
        }
        private void DoubleArray()
        {
            var temp = new T[inneArray.Length*2];
            System.Array.Copy(inneArray, temp, inneArray.Length);
            inneArray = temp;
             
        }
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        //public void RemoveAt(int index)
        //{

        //    if (index >= Count) throw new Exception("İstediğiniz İndex Listede Yok");
        //    var value = FindAtIndex(index);

        //    foreach (var item in temp)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
        //private T FindAtIndex(int index)
        //{
        //    var Index = 0;
        //    foreach (var item in inneArray)
        //    {
        //        if (Index == index){
        //            return item;
        //        }
        //        Index++;

        //    }
        //    throw new Exception("Boyle Bir Index Yok");
        //}
        public IEnumerator<T> GetEnumerator()
        {
            return inneArray.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

