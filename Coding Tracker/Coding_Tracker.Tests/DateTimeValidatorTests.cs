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

        [Fact]
        public void ValidateDateResponse_EmptyString_ThrowsFormatException()
        {
            var emptyDate = "";
            var format = "dd-MM-yyyy HH:mm";
            Assert.Throws<FormatException>(() => DateTimeValidator.ValidateDateResponse(emptyDate, format));
        }

        [Fact]
        public void ValidateEndDateResponse_EndBeforeStart_ThrowsFormatException()
        {
            
            var start = new DateTime(2026, 1, 2, 9, 0, 0);
            var endInput = "01-01-2026 09:00"; 
            var format = "dd-MM-yyyy HH:mm";

            
            Assert.Throws<FormatException>(() => DateTimeValidator.ValidateEndDateResponse(start, endInput, format));
        }

    }
}
