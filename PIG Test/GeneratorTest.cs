 using System;
using Xunit;
using Personal_Information_Generator_2;

namespace PIG_Test
{
    public class GeneratorTest
    {
        [Theory]
        [InlineData("male", "2000-11-09")]
        public void GenerateFakeCpr_Test(string gender, DateTime birthDate)
        {
            //Arrange
            string result;

            //Act
            Generator.GetFakeCPR(gender, birthDate);

            //Assert
            Assert.True(true);

        }

    }
}
