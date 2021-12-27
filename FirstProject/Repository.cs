using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // generic class to show how use generic types in methods
    public class Repository<T> where T : IEntity //adding generic constrains 
    {
        private List<T> data = new List<T>();
        //adding element to list
        public void AddElement(T element)
        {
            if (element != null)
            {
                Console.WriteLine(element.Id);
                data.Add(element);
            }
        }

        //because we demand our generic type to implement interface IEntity we know that each object passed as argument has its id
        //so we can create method finding element using its id
        public T GetElementById(int id)
        {
            var element = data.FirstOrDefault(el => el.Id == id);
            return element;
        }
        //take list's element by index number
        public T GetElement(int index)
        {
            if (index < data.Count)
            {
                return data[index];
            }
            else
            {
                //throw new IndexOutOfRangeException();
                //or give default value, for reference type it is null, for numbers it is zero
                return default(T); //or just return default;
            }
        }
    }
    //Repository with multiple generic parameters
    public class Repository<TKey, TValue> //may have same name
    {
        private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();
        //adding element to list
        public void AddElement(TKey key, TValue element )
        {
            if (element != null)
            {
                data.Add(key, element);
            }
        }
        //take list's element by index number
        public TValue GetElement(TKey key)
        {
            if (data.TryGetValue(key, out TValue result)
            {
                return result;
            }
            else
            {
                //throw new IndexOutOfRangeException();
                //or give default value, for reference type it is null, for numbers it is zero
                return default; //or return default(T);
            }
        }

    }
}
