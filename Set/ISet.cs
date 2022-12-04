using System;
using System.Collections.Generic;
using System.Collections;



namespace Set
{
    public interface ISet<T>: IEnumerable<T>
    {
        void Add(ISet<T> s);

        void Add(T value);

        void Remove(ISet<T> s);

        void Remove(T value);

        bool Contains(T value);

        int Size { get; }

        List<T> Elements { get; }

        
        
        




        //If s1 is {1, 2, 4} and s2 is {2, 4} then, 
        //Set.Union(s1, s2) returns
        //{ 1, 2,4}
        //If s1 is {1, 2, 4} and s2 is {3, 5} then, 
        //Set.Union(s1, s2) returns
        //{ 1,2,3,4,5}
        //If s1 is {} and s2 is {} then, 
        //Set.Union(s1, s2) returns
        //{ }


    }
}