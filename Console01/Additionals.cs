using System;
using System.Collections.Generic;
using System.Linq;

namespace Console01 
{
    class Book
    {
        private string name;
        private string author;

        public Book()
        {

        }

        public string Name
        {
            get 
            {
                return name;
            }

            set 
            { 
                name = value; 
            }
   
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;   
            }
        }

    }


    class Nullable<TObject> where TObject : struct
    {
        public object _value;
        public Nullable()
        {
            
        }

        public Nullable(TObject value)
        {
            _value = value;        
        }

        // public bool HasValue()
        // {
        //     return (_value != null);
        // }
        public bool HasValue 
        { 
            get {return (_value != null); } 
        }


        public TObject GetValueOrDefault()
        {
            if(HasValue)
            {
                return (TObject)_value;
            }

            return default(TObject);
        }
    }



    public class GenericDictionary<TKey,TValue>
    {
        public void Add(TKey _key, TValue _value)
        {
        }
    }
    
    public class GenericList<T>
    {
        public void Add(T value)
        {
        
        }

        public T this[int Index]
        {       
            get 
            { 
                throw new NotImplementedException();
            } 
        }
    }

    //  where T : IComparable
    //  where T : Product
    //  where T : struct
    //  where T : class
    //  where T : new()
    public class Comparison<TObject> where TObject : new()
    {
        public TObject Compare<TObject>(TObject a, TObject b) where TObject : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b; 
        } 
    
        public void DoSomething()
        {
            var x = new TObject();
        }
    
    }
} 