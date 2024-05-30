
using ClassLibrary;
using System;

namespace laba_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание коллекций
            var collection1 = new MyObservableCollection<Auto>();
            var collection2 = new MyObservableCollection<Auto>();

            // Создание объектов журнала
            var journal1 = new Journal();
            var journal2 = new Journal();

            // Подписка на события
            collection1.CollectionCountChanged += journal1.CollectionCountChangedHandler;
            collection1.CollectionReferenceChanged += journal1.CollectionReferenceChangedHandler;

            collection1.CollectionReferenceChanged += journal2.CollectionReferenceChangedHandler;
            collection2.CollectionReferenceChanged += journal2.CollectionReferenceChangedHandler;

            // Внесение изменений в коллекции
            var auto1 = new Auto("Toyota", 2020, "Red", 20000, 150);
            var auto2 = new Auto("Honda", 2018, "Blue", 15000, 160);
            var auto3 = new Auto("BMW", 2019, "Black", 30000, 140);

            collection1.Add(auto1);
            collection1.Add(auto2);
            collection2.Add(auto3);

            collection1.Remove(auto2);

            collection1[0] = new Auto("Audi", 2021, "White", 25000, 130);

            // Вывод данных журнала
            Console.WriteLine("Журнал 1:");
            Console.WriteLine(journal1);

            Console.WriteLine("Журнал 2:");
            Console.WriteLine(journal2);
            Console.ReadLine();
        }
    }
}
