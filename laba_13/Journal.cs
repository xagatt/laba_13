using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_13
{
    public class Journal
    {
        private List<JournalEntry> _entries = new List<JournalEntry>();

        public void CollectionCountChangedHandler(object sender, CollectionHandlerEventArgs e)
        {
            _entries.Add(new JournalEntry(sender.GetType().Name, e.ChangeType, e.ChangedItem.ToString()));
        }

        public void CollectionReferenceChangedHandler(object sender, CollectionHandlerEventArgs e)
        {
            _entries.Add(new JournalEntry(sender.GetType().Name, e.ChangeType, e.ChangedItem.ToString()));
        }

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
            foreach (var entry in _entries)
            {
                result.AppendLine(entry.ToString());
            }
            return result.ToString();
        }
    }
}
