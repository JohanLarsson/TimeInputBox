namespace TimeInputBox.Tests
{
    using NUnit.Framework;

    public class PalindromeTests
    {
        [TestCase("Mom", true)]
        [TestCase("Noon", true)]
        [TestCase("Kayak", true)]
        [TestCase("Was it a cat I saw?", true)]
        [TestCase("Not a palindrom", false)]
        public void IsPalindrome(string text, bool isPalindrom)
        {
            var result = Palindrome.IsPalindrome(text);
            Assert.AreEqual(isPalindrom, result);
        }
    }
}
