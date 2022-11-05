using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Npc : ICharacter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        private Npc(Npc npc)
        {
            Id = Guid.NewGuid();
            Name = npc.Name;
            Gender = npc.Gender;
            Age = npc.Age;
        }

        public Npc(string name, string gender, int age)
        {
            Id = Guid.NewGuid();
            Name = name;
            Gender = gender;
            Age = age;
        }

        public ICharacter Clone()
        {
            var copy = new Npc(this);
            return copy;
        }
    }
}
