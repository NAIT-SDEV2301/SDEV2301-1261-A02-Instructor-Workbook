namespace BookLibrary.Tests
{
    public class BookTests
    {
        [Fact]
        public void Constructor_ValidPages_SetsPages()
        {
            // Arrange
            string title = "Clean Code";
            int pages = 464;
            // Act
            var book = new Book(title, pages);
            // Assert
            Assert.Equal(464, book.Pages);
        }

        [Fact]
        public void Constructor_ZeroPages_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new Book("Invalid", 0));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-50)]
        public void Constructor_NonPositivePages_Throws(int pages)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new Book("Invalid", pages));

        }
    }
}
