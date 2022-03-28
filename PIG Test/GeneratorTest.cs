 using System;
using Xunit;
using Personal_Information_Generator_2;

namespace PIG_Test
{
    public class GeneratorTest
    {
        [Theory]
        [InlineData("male", "2000-11-09")]
        [InlineData("male", "1900-04-09")]
        [InlineData("male", "1922-08-09")]
        [InlineData("male", "1999-07-09")]
        public void GenerateFakeCpr_Test_Male(string gender, DateTime birthDate)
        {
            //Arrange
            string result;

            //Act
            result=Generator.GetFakeCPR(gender, birthDate);

            //Assert
            Assert.True(Convert.ToInt64(result)%2!=0);

        }
        [Theory]
        [InlineData("female", "2000-11-09")]
        public void GenerateFakeCpr_Test_Female(string gender, DateTime birthDate)
        {
            //Arrange
            string result;

            //Act
            result = Generator.GetFakeCPR(gender, birthDate);

            //Assert
            Assert.True(Convert.ToInt64(result) % 2 == 0);

        }
        [Theory]
        [InlineData("idontknowyet", "2000-11-09")]
        public void GenerateFakeCpr_Test_Fantasy(string gender, DateTime birthDate)
        {
            //Arrange
            //string result;

            //Act
            //result = Generator.GetFakeCPR(gender, birthDate);

            //Assert
            Assert.Throws<Exception>(()=>Generator.GetFakeCPR(gender, birthDate));

        }
        [Fact]
        public void GenerateFakePhone_Test_Length()
        {
            //Arrange
            string result;

            //Act
            result = Generator.GetPhoneNumber().ToString();

            //Assert
            Assert.True(result.Length==8);

        }

        [Fact]
        public void GenerateFakePhone_Test_Start()
        {
            //Arrange
            string result;

            //Act
            result = Generator.GetPhoneNumber().ToString();

            //Assert
            Assert.True(result.Substring(0,1)!="1");
        }


    }
}
