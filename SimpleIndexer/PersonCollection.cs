using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    internal class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        // Custom indexer for this class.
        public Person this[int index]
        {
        get => (Person) arPeople[index];
                set => arPeople.Insert(index, value);
        }
        public int Count => arPeople.Count;
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
