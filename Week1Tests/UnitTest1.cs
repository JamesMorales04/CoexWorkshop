using Xunit;
using CoexWorkshop;

namespace Week1Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidRegexValidationTest()
        {
            //Act
            var validationResult = Week1.RegexValidation("Asdasdasdasdfdf");

            //Assertion
            Assert.Empty(validationResult);
        }

        [Theory]
        [InlineData("Asd")]
        [InlineData("Aasddsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsddfadasdsdssdsdsdsdsdsdsdsdsdsddssd")]
        [InlineData("asdsdsdsd")]
        public void IfValidationFailTest(string id)
        {
            //Act
            var validationResult = Week1.RegexValidation(id);
            
            //Assertion
            Assert.NotEmpty(validationResult);
        }
    }
}
