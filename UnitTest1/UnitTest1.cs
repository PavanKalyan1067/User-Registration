using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = RegexSample.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }
    }
}


