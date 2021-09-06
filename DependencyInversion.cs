using System;
using System.Collections.Generic;

namespace Dependency_Inversion_Principle
{

    public class Person
    {
        public enum Relationship
        {
            Parent,
            Child,
            Sibling
        }
        public string Name;
        //public DateTime DateOfBirth;

        //low-level
        public class Relationships
        {
            private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

            public void AddParentAndChild(Person parent, Person child)
            {
                relations.Add((parent, Relationship.Parent, child));
                relations.Add((child, Relationship.Child, parent));
            }
            public List<(Person, Relationship, Person)> Relations => relations; //make this public field
        }

        public class Research
        {
            public Research(Relationships relationships )
            {
                //access modifier of the relation changed to public
                var relations = relationships.Relations;
                
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                var parent = new Person { Name = "John" };
                var child1 = new Person { Name = "Chris" };
                var child2 = new Person { Name = "Mary" };

                var relationships = new Relationships();
                relationships.AddParentAndChild(parent, child1);
                relationships.AddParentAndChild(parent, child2);
            }
        }
    }
}
