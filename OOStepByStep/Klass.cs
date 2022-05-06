using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

namespace OOStepByStep
{
    public class Klass : ISubject
    {
        private readonly int number;

        private IList<IObserver> observers = new List<IObserver>();
        private IList<Student> students = new List<Student>();

        private Student newcomer;
        public Klass(int number)
        {
            this.number = number;
        }

        public void AddMember(Student student)
        {
            newcomer = student;
            Notify();
            student.Join(this);
            students.Add(student);
            Attach(student);
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ToList().ForEach(observer => observer.Update(this));
        }

        public Student GetNewcomer()
        {
            return newcomer;
        }

        public int GetNumber()
        {
            return number;
        }
    }
}