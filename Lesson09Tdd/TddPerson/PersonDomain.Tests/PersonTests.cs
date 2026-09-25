using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PersonDomain.Tests
{
    public class PersonTests
    {
        [Fact]
       public void Constructor_ValidName_SetsNames()
        {
            var person = new Person("Ada", "Lovelace");

            Assert.Equal("Ada", person.FirstName);
            Assert.Equal("Lovelace", person.LastName);

        }

        [Fact]
        public void FullName_ValidName_ReturnsLastCommaFirst()
        {
            var person = new Person("Ada", "Lovelace");
            Assert.Equal("Lovelace, Ada", person.FullName);
        }

        [Theory]
        [InlineData(null, "Lovelace, Ada")]
        [InlineData("Ada", "Ada")]
        public void DisplayName_OptionalName_ReturnsExpected(
            string? preferredName, string expected)
        {
            var person = new Person("Ada", "Lovelace", preferredName);
            
            Assert.Equal(expected, person.DisplayName);
        }

        [Fact]
        public void Constructor_PaddedNames_TrimsNames()
        {
            var person = new Person("  Ada  " , " Lovelace ");

            Assert.Equal("Ada", person.FirstName);
            Assert.Equal("Lovelace", person.LastName);
        }
    }
}
