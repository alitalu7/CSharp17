using System.Collections;

ArrayList liste = new ArrayList();

liste.Add("Ali");
liste.Add("Talu");
liste.Add(23);
liste.Add("E");

foreach(var list in liste)
{
    Console.WriteLine(list);
}
