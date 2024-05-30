using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_13
{
    public class JournalEntry
    {
        public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public string ChangedItemData { get; set; }

        public JournalEntry(string collectionName, string changeType, string changedItemData)
        {
            CollectionName = collectionName;
            ChangeType = changeType;
            ChangedItemData = changedItemData;
        }

        public override string ToString()
        {
            return $"Коллекция: {CollectionName}, Изменение: {ChangeType}, Автомобиль: {ChangedItemData}";
        }
    }
}
