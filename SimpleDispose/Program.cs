using SimpleDispose;

Console.WriteLine("***** Fun with Dispose *****\n");
// Create a disposable object and call Dispose()
// to free any internal resources.
MyResourceWrapper rw = new MyResourceWrapper();
/*if(rw is IDisposable)
{
    rw.Dispose();
}*/
/*try
{
    // Use the members of rw.
}
finally
{
    // Always call Dispose(), error or not.
    rw.Dispose();
}*/
/*// Dispose() is called automatically when the using scope exits.
using (MyResourceWrapper rwa = new MyResourceWrapper())
{
    // Use rwa object.
}*/
/*using (MyResourceWrapper rwb= new MyResourceWrapper(), rw2 = new MyResourceWrapper())
{
    // Use rwb and rw2 objects.
}*/
Console.ReadLine();
Console.WriteLine("Demonstrate using declarations");
//UsingDeclaration();
// /\-- doesnt work, bad book or Am I just dumb?
Console.ReadLine();