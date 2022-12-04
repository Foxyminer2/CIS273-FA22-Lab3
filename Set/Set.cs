using System;
using System.Collections;
using System.Collections.Generic;
using Set;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        private HashSet<T> hashSet;

        public Set()
        {
            hashSet = new HashSet<T>();
        }

        public int Size => hashSet.Count;

        public List<T> Elements
        {

            get
                {
                List<T> elements = new List<T>();

                foreach(var element in hashSet)
                {
                    elements.Add(element);
                }
                    //do work

                    //return result
                    return elements;
                }
        }

public void Add(ISet<T> s)
        {
            foreach (var item in s)
            {
                this.Add(item);
            }
        }

        public void Add(T value)
        {
            hashSet.Add(value);
        }

        public bool Contains(T value)
        {
            foreach(var num in hashSet)
            {
                if (num.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }


        public void Remove(ISet<T> s)
        {
            foreach (var item in s)
            {
                this.Remove(item);
            }
        }

        public void Remove(T value)
        {
            hashSet.Remove(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return hashSet.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Set<T> Union(ISet<T> s1, ISet<T> s2)
        {
            Set<T> union = new Set<T>();

            foreach(var element in s1)
            {
                union.Add(element);
            }

            foreach (var element in s2)
            {
                union.Add(element);
            }

            return union;
        }

        public static Set<T> Intersection(ISet<T> s1, ISet<T> s2)
        {
            Set<T> result = new Set<T>();
            foreach(var element in s1)
            {
                if (s2.Contains(element))
                {
                    result.Add(element);
                }
            }
            //only elements in both sets gets return in another set
            return result;
        }


    }
}

