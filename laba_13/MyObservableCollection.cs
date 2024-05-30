using System.Text;

namespace laba_13
{
    public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);

    public class MyObservableCollection<T> : MyCollection<T>
    {
        public event CollectionHandler CollectionCountChanged;
        public event CollectionHandler CollectionReferenceChanged;

        public MyObservableCollection() : base() { }

        public MyObservableCollection(int length) : base(length) { }

        public MyObservableCollection(MyCollection<T> collection) : base(collection) { }

        public override void Add(T item)
        {
            base.Add(item);
            CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs("Добавление", item));
        }

        public override bool Remove(T item)
        {
            bool result = base.Remove(item);
            if (result)
            {
                CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs("Удаление", item));
            }
            return result;
        }

        public override void Clear()
        {
            base.Clear();
            CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs("Очистка", null));
        }

        public override T this[int index]
        {
            get => base[index];
            set
            {
                T oldItem = base[index];
                base[index] = value;
                CollectionReferenceChanged?.Invoke(this, new CollectionHandlerEventArgs("Замена", value));
            }
        }

        public void AutoFill(int count)
        {
            for (int i = 0; i < count; i++)
            {
                T item = default(T);
                Add(item);
            }
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (T item in items)
            {
                sb.Append(item?.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
