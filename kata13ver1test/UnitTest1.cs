using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata13ver1;
using kata13ver1test;
namespace kata13ver1test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validate_isbn_detect_correct_arithmetic()
        {
            string isbn = "978-1734314502";
            Assert.IsTrue(kata13ver1.isbn13check.CheckISBN13(isbn));
        }
        [TestMethod]
        public void validate_isbn_detect_wrong_arithmetic()
        {
            string isbn = "978-1734314509";
            Assert.IsFalse(kata13ver1.isbn13check.CheckISBN13(isbn));
        }
    }
}
