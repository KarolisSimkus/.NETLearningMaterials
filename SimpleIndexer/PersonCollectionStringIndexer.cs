using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    internal class PersonCollectionStringIndexer : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        // This indexer returns a person baed on a string index
        public Person this[string name]
        { 
            get { return (Person)listPeople[name]; } 
            set { listPeople[name] = value; } 
        }
        public void ClearPeople()
        {
            listPeople.Clear();
        }
        public int Count => listPeople.Count;
        IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();
    }
}
