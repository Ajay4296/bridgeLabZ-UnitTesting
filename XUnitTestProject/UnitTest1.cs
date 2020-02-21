using System;
using Xunit;
using UserRegistrationForm;
namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
            public void ForvalidationName()
        {
            string str = "Ajay4296";
                
           var actual = Program.CheckUserName(str);
            Assert.True(actual);
        }
        [Fact]
        public void ForValidationOfMobile() 
        {
            string str1 = "+919074637906";
           
            var actual = Program.CheckMobileNumber(str1);
            Assert.True(actual);

        } 
        [Fact]
        public void ForvalidationOfemail()
        {
            string str2 = "ajayk4296@gmail.com";
            var actual2 = Program.CheckEmail(str2);
            Assert.True(actual2);
        }
        [Fact]
        public void ForvalidationOfpwd()
        {
            string str3 = "Ajay@1995";
            var actual2 = Program.Checkpwd(str3);
            Assert.True(actual2);
        }
    }
}
