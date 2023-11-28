using Interfaces;
using System.Reflection.Metadata;

List<ISound> zad5 = new List<ISound>();
zad5.Add(new Car());
zad5.Add(new Phone());

for(int i = 0; i < zad5.Count; i++)
{
    Console.WriteLine(zad5[i].MakeASound());
}