using System;
using Crispy_Waddle_Console.Application.Models;
using Xunit;

namespace Crispy_Waddle_Console_Tests.Models
{
    public class PhotoTests
    {
        [Fact]
        public void PrintToStringWithIdAndTitleWhenToStringCalled()
        {
            Photo photo = new Photo() { Id = 5, Title = "This is a title" };
            Assert.Equal("[5] This is a title", photo.ToString());
        }
    }
}
