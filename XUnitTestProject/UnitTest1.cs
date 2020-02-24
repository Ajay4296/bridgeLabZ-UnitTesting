using System;
using Xunit;
using UserRegistrationForm;
namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
            public void CheckName_ForvalidationName()
        {
            string str = "Ajay4296";
                
           var actual = Registration.CheckUserName(str);
            Assert.True(actual);
        }
        [Fact]
        public void CheckMobileNumber_ForValidationOfMobile() 
        {
            string str1 = "+919074637906";
           
            var actual = Registration.CheckMobileNumber(str1);
            Assert.True(actual);

        } 
        [Fact]
        public void CheckEmail_ForvalidationOfemail()
        {
            string str2 = "ajayk4296@gmail.com";
            var actual2 = Registration.CheckEmail(str2);
            Assert.True(actual2);
        }
        [Fact]
        public void CheckPassword_ForvalidationOfpwd()
        {
            string str3 = "Ajay@1995";
            var actual2 = Registration.CheckPassword(str3);
            Assert.True(actual2);
        }
    }
}
