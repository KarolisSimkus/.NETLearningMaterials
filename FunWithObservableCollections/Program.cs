using FunWithObservableCollections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

ObservableCollection<Person> people = new ObservableCollection<Person>()
{
    new Person{ FirstName = "Peter", LastName = "Murphy", Age=52},
    new Person{ FirstName = "Kevin", LastName = "Key", Age=48},
};
// Wire up the CollectionChanged event.
people.CollectionChanged += people_CollectionChanged;
static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("Action for this event: {0}", e.Action);
    
    // They removed something.
    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the OLD items: ");
        foreach(Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine();
    }
    // They added something.
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        // Now show the NEW items that were inserted.
        Console.WriteLine("Here are the NEW items:");
        foreach (Person p in e.NewItems)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
// Now add a new item.
people.Add(new Person { FirstName = "Fred", LastName = "Murphy", Age = 52 });
// Remove an item.
people.RemoveAt(0);