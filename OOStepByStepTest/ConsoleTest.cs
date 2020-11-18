using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Test_Console()
        {
            // given
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            // when
            new Class1().Print();

            // then
            Assert.Equal("console\n", fakeOutput.ToString());
        }
    }
}
