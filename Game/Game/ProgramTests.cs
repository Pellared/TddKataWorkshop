using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ProgramTests
    {
        [Xunit.Fact]
        public void Should_throw_exception_if_input_is_below_1()
        {
            var input = "0";
            Xunit.Assert.Throws<ApplicationException>(()=> StringInputParser.Parse(input));
        }

        [Xunit.Fact]
        public void Should_throw_exception_if_input_is_above_3000()
        {
            var input = "30001";
            Xunit.Assert.Throws<ApplicationException>(() => StringInputParser.Parse(input));
        }
    }
}
