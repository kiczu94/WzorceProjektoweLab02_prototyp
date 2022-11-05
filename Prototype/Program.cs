using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Npc("Janusz", "Male", 24);
            var person2 = (Npc)person.Clone();

            Console.WriteLine($"First person data: name:{person.Name} , gender: {person.Gender}, Age: {person.Age}, id: {person.Id}");
            Console.WriteLine($"Second person data: name:{person2.Name} , gender: {person2.Gender}, Age: {person2.Age}, id: {person2.Id}");

        }
    }
}
