using System;

namespace laba_13
{
    public class CollectionHandlerEventArgs : EventArgs
    {
        public string ChangeType { get; set; }
        public object ChangedItem { get; set; }

        public CollectionHandlerEventArgs(string changeType, object changedItem)
        {
            ChangeType = changeType;
            ChangedItem = changedItem;
        }

        public override string ToString()
        {
            return $"ChangeType: {ChangeType}, Измененный автомобиль: {ChangedItem}";
        }
    }
}
