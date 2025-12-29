namespace Coding_Tracker.Tests
{
    public class DateTimeValidatorTests
    {
        [Fact]
        public void ValidateDateResponse_ValidDate_ReturnsDateTime()
        {
            var validDate = "25-12-2023 14:30";
            var format = "dd-MM-yyyy HH:mm";
            
            var result = DateTimeValidator.ValidateDateResponse(validDate, format);
            
            Assert.Equal(new DateTime(2023, 12, 25, 14, 30, 0), result);
        }

        [Fact]
        public void ValidateDateResponse_InvalidDate_ThrowsFormatException()
        {
            var invalidDate = "41/13/2025 14:30";
            var format = "dd-MM-yyyy HH:mm";
            
            Assert.Throws<FormatException>(() => DateTimeValidator.ValidateDateResponse(invalidDate, format));
        }
    }
}
