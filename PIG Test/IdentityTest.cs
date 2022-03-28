using Personal_Information_Generator_2.Models;
using System;
using Xunit;

namespace PIG_Test
{
    public class IdentityTest
    {

        // The "persons:" part should be removed from the file. Someone should fix this.
        [Fact]
        public void GetFullNameAndGender_Test()
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

        [Fact]
        public void CreateCprDateMatchesCpr_Test()
        {
            //Arrange
            Identity testPerson = new Identity();
            string day = testPerson.BirthDate.Day.ToString();
            string month = testPerson.BirthDate.Month.ToString();


            //Act
            testPerson.CreateCPR();

            day = testPerson.BirthDate.Day < 10 ? "0" + day : day;
            month = testPerson.BirthDate.Month < 10 ? "0" + month : month;


            //Assert

            Assert.Contains(day + month + testPerson.BirthDate.Year.ToString().Substring(2, 2), testPerson.Cpr.ToString());

        }

        [Fact]
        public void CreateCprReflectsOnGender_Test()
        {
            //Arrange
            Identity testPerson = new Identity();

            //Act
            testPerson.CreateCPR();

            //Assert
            if (testPerson.Gender == "male")
            {
                Assert.True(Convert.ToInt64(testPerson.Cpr) % 2 == 1);
            }
            if (testPerson.Gender == "female")
            {
                Assert.True(Convert.ToInt64(testPerson.Cpr) % 2 == 0);

            }
        }
        [Fact]
        public void CPRLenght()
        {
            //Arrange
            Identity testPerson = new Identity();

            //Act
            testPerson.CreateCPR();

            //Assert
            Assert.True(testPerson.Cpr.Length == 10);
        }


    }
}