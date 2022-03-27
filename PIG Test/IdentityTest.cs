using Personal_Information_Generator_2.Models;
using Xunit;

namespace PIG_Test
{
    public class IdentityTest
    {

        // The "persons:" part should be removed from the file. Someone should fix this.
        [Fact]
        public void GetFullNameAndGender()
        {
            //Arrange
            Identity testPerson = new Identity();

            //Act
            testPerson.GetFullNameAndGender();

            //Assert
            Assert.True(testPerson.FullName.Length > 0);
            Assert.Contains(" ", testPerson.FullName);
            Assert.True(testPerson.Gender.Length > 0);

        }
    }
}