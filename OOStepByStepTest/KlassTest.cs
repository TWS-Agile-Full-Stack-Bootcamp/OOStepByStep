using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class KlassTest
    {
        [Fact]
        public void Should_Say_Welcome_When_A_New_Student_Join()
        {
            // given
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            Student tom = new Student("Tom", 18);
            Student jim = new Student("Jim", 18);
            Klass klass = new Klass(2);

            // when
            klass.AddMember(tom);
            klass.AddMember(jim);

            // then
            Assert.EndsWith("My name is Tom. I am 18 years old. " +
                            "I am a student of class 2. Welcome Jim join class 2.",
                fakeOutput.ToString());
        }
    }
}
