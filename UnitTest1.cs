using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kata13ver2test;
namespace kata13ver2test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validate_correct_isbn_operation()
        {
            string kata = "978-1734314502";
            Assert.IsTrue(kata13ver2.checkisbn13.isbnchecker(kata));
        }
        [TestMethod]
        public void validate_incorrect_isbn_operation()
        {
            string kata = "978-173431450211391";
            Assert.IsFalse(kata13ver2.checkisbn13.isbnchecker(kata));
        }
    }
}
