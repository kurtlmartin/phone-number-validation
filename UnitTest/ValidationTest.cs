using PhoneNumberValidation;
using Xunit;

namespace UnitTest
{
    public class ValidationTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void LoadValidation_class()
        {
            var newClass = new Validation();

            Assert.NotNull(newClass);
        }

        [Fact]
        public void Fail_pass_bad_number()
        {
            var validation = new Validation();

            var sut = validation.IsPhoneNumberValide("asdf");

            Assert.False(sut);
        }

        [Theory]
        [InlineData("555.555.5555")]
        [InlineData("555 555 5555")]
        [InlineData("5555555555")]
        [InlineData("(555)5555555")]
        [InlineData("(555)555-5555")]
        [InlineData("555-555-5555")]
        public void True_send_valid_number_no_contryCode(string value)
        {
            var sut = new Validation().IsPhoneNumberValide(value);

            Assert.True(sut);
        }

        [Theory]
        [InlineData("1555.555.5555")]
        [InlineData("1 555 555 5555")]
        [InlineData("15555555555")]
        [InlineData("1(555)5555555")]
        [InlineData("1(555)555-5555")]
        [InlineData("1555-555-5555")]
        public void True_send_valid_number_contryCode_no_Plus(string value)
        {
            var sut = new Validation().IsPhoneNumberValide(value);
            Assert.True(sut);
        }

        [Theory]
        [InlineData("+1555.555.5555")]
        [InlineData("+1555 555 5555")]
        [InlineData("+15555555555")]
        [InlineData("+1(555)5555555")]
        [InlineData("+1(555)555-5555")]
        [InlineData("+1555-555-5555")]
        public void True_send_valid_number_contryCode_With_Plus(string value)
        {
            var sut = new Validation().IsPhoneNumberValide(value);
            Assert.True(sut);
        }
    }
}