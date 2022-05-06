using System;

namespace OOStepByStep
{
    public class Student : IObserver
    {
        private readonly int age;
        private Klass klass;

        public Student(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        private string Name { get; }

        public void Join(Klass klass)
        {
            this.klass = klass;
        }

        public string Introduce()
        {
            return $"My name is {Name}. I am {age} years old. I am a student of class {klass.GetNumber()}.";
        }

        public void Update(ISubject subject)
        {
            Console.Write(this.Introduce() + this.Welcome(subject));
        }

        private string Welcome(ISubject subject)
        {
            return $" Welcome {subject.GetNewcomer().Name} join class {klass.GetNumber()}.";
        }
    }
}