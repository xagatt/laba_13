using System.Collections;
using System.Collections.Generic;

namespace laba_13
{
    public class MyCollection<T> : ICollection<T>, IEnumerable<T>, IList<T>
    {
        protected List<T> items;

        public MyCollection()
        {
            items = new List<T>();
        }

        public MyCollection(int length)
        {
            items = new List<T>(length);
            for (int i = 0; i < length; i++)
            {
                items.Add(default(T));
            }
        }

        public MyCollection(MyCollection<T> collection)
        {
            items = new List<T>(collection.items);
        }

        public int Count => items.Count;

        public bool IsReadOnly => false;

        public virtual void Add(T item)
        {
            items.Add(item);
        }

        public virtual void Clear()
        {
            items.Clear();
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public virtual bool Remove(T item)
        {
            return items.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public virtual T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

        public int IndexOf(T item)
        {
            return items.IndexOf(item);
        }

        public virtual void Insert(int index, T item)
        {
            items.Insert(index, item);
        }

        public virtual void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }
    }
}
