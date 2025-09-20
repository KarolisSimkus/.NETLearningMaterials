using FunWithGenericCollections;
using System;

//UseGenericList();
//UseGenericStack();
UseSortedSet();
static void UseGenericList()
{
    List<Person> list = new List<Person>()
    {
        new Person{FirstName= "Homer", LastName= "Simpson", Age=47},
        new Person{FirstName= "Marge", LastName= "Simpson", Age=45},
        new Person{FirstName= "Lisa", LastName= "Simpson", Age=9},
        new Person{FirstName= "Bart", LastName= "Simpson", Age=8},
    };

    Console.WriteLine("Items in list: {0}", list.Count);

    foreach (Person p in list)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine("\n-> Inserting new person");
    list.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2});
    Console.WriteLine("Items in list: {0}", list.Count);

    Person[] arrayOfPeople = list.ToArray();
    foreach (var item in arrayOfPeople)
    {
        Console.WriteLine("First Names: {0}", item.FirstName);
    }
}
static void UseGenericStack()
{
    Stack<Person> stackOfPeople = new();
    stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
    // Now look at the top item, pop it, and look again.
    Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    try
    {
        Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek());
        Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("\nError! {0}", ex.Message);
    }
}
static void UseGenericQueue()
{
    Queue<Person> peopleQueue = new();
    peopleQueue.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    peopleQueue.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    peopleQueue.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

    Console.WriteLine("{0} is First in line!", peopleQueue.Peek().FirstName);

    peopleQueue.Dequeue();
    peopleQueue.Dequeue();
    peopleQueue.Dequeue();
    try
    {
        peopleQueue.Dequeue();
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine("Error! {0}", e.Message);
    }
    
}
static void UsePriorityQueue()
{
    Console.WriteLine("* Fun with Generic Priority Queues *\n");
    PriorityQueue<Person, int> peopleQ = new();
    peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }, 1);
    peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 }, 3);
    peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 }, 3);
    peopleQ.Enqueue(new Person { FirstName = "Bart", LastName = "Simpson", Age = 12 }, 2);
    while (peopleQ.Count > 0)
    {
        Console.WriteLine(peopleQ.Dequeue().FirstName); //Displays Lisa
        Console.WriteLine(peopleQ.Dequeue().FirstName); //Displays Bart
        Console.WriteLine(peopleQ.Dequeue().FirstName); //Displays either Marge or Homer
        Console.WriteLine(peopleQ.Dequeue().FirstName); //Displays the other priority 3 item
    }
}
static void UseSortedSet()
{
    SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
        {
            new Person {FirstName= "Homer", LastName="Simpson",Age = 47},
            new Person {FirstName= "Marge", LastName="Simpson",Age = 45},
            new Person {FirstName= "Lisa", LastName="Simpson",Age = 9},
            new Person {FirstName= "Bart", LastName="Simpson",Age = 8},
        };

    foreach (Person person in setOfPeople)
    {
        Console.WriteLine(person);
    }
    Console.WriteLine();

    setOfPeople.Add(new Person { FirstName = "Aaaaa", LastName = "Simpson", Age = 1 });
    setOfPeople.Add(new Person { FirstName = "Bbbbb", LastName = "Simpson", Age = 32 });

    foreach (var item in setOfPeople)
    {
        Console.WriteLine(item);
    }
}
static void UseDictionary()
{
    // Populate using Add() method
    Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
    peopleA.Add("Homer", new Person
    {
        FirstName = "Homer",
        LastName = "Simpson",
        Age= 47
    });
    peopleA.Add("Marge", new Person
    {
        FirstName = "Marge",
        LastName = "Simpson",
        Age= 45
    });
    peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
    
    // Get Homer.
    Person homer = peopleA["Homer"];
    Console.WriteLine(homer);
    
    // Populate with initialization syntax.
    Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
    {
        { "Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
        { "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
        { "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
    };

    // Get Lisa.
    Person lisa = peopleB["Lisa"];
    Console.WriteLine(lisa);

    // Populate with dictionary initialization syntax.
    Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
    {
        ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
        ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
        ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
    };
}
