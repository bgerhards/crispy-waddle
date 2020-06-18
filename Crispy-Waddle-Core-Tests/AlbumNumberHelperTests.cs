using System;
using Xunit;
using Crispy_Waddle_Core;

namespace Crispy_Waddle_Console_Tests
{
    public class AlbumNumberHelperTests
    {
        public AlbumNumberHelperTests()
        {
        }

        [Fact]
        public void AlbumNumberIsMinimumValidNumber()
        {
            var result = AlbumNumberHelper.ValidNumber("1");
            Assert.True(result);
        }
    }
}
