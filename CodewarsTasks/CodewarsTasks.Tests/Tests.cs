using NUnit.Framework;

namespace CodewarsTasks.Tests
{
    public class Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 2 }, Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 1 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { 1, 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.AreEqual(new int[] { }, Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
            Assert.AreEqual(new int[] { 3 }, Kata.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }

        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
        }

        [Test]
        public void MultilineString()
        {
            Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
        }

        [Test]
        public void OneMoreForGoodMeasure()
        {
            Assert.AreEqual("Wht r y,  cmmnst?", Kata.Disemvowel("What are you, a communist?"));
        }

        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void AccumTest()
        {
            testing(Kata.Accum("ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
            testing(Kata.Accum("NyffsGeyylB"), "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
            testing(Kata.Accum("MjtkuBovqrU"), "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
            testing(Kata.Accum("EvidjUnokmM"), "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
            testing(Kata.Accum("HbideVbxncC"), "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
        }

        [Test]
        public void GetMiddleTest()
        {
            Assert.AreEqual("es", Kata.GetMiddle("test"));
            Assert.AreEqual("t", Kata.GetMiddle("testing"));
            Assert.AreEqual("dd", Kata.GetMiddle("middle"));
            Assert.AreEqual("A", Kata.GetMiddle("A"));
        }

        [Test]
        public void IsDigitTest()
        {
            Assert.AreEqual(false, "".IsDigit());
            Assert.AreEqual(true, "7".IsDigit());
            Assert.AreEqual(false, " ".IsDigit());
            Assert.AreEqual(false, "a".IsDigit());
            Assert.AreEqual(false, "a5".IsDigit());
            Assert.AreEqual(false, "14".IsDigit());
        }

        [Test, Description("It should return correct text")]
        public void ShowWhoLikesPostTest()
        {
            Assert.AreEqual("no one likes this", Kata.ShowWhoLikesPost(new string[0]));
            Assert.AreEqual("Peter likes this", Kata.ShowWhoLikesPost(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Kata.ShowWhoLikesPost(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Kata.ShowWhoLikesPost(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.ShowWhoLikesPost(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }

        [Test]
        public void XOTest()
        {
            Assert.AreEqual(true, Kata.XO("xo"));
            Assert.AreEqual(true, Kata.XO("xxOo"));
            Assert.AreEqual(false, Kata.XO("xxxm"));
            Assert.AreEqual(false, Kata.XO("Oo"));
            Assert.AreEqual(false, Kata.XO("ooom"));
        }

        [Test]
        public void ValidatePinTest()
        {
            Assert.AreEqual(false, Kata.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, Kata.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, Kata.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, Kata.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, Kata.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, Kata.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, Kata.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, Kata.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
            Assert.AreEqual(false, Kata.ValidatePin("00000000"), "Wrong output for \"00000000\"");

            Assert.AreEqual(false, Kata.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, Kata.ValidatePin(".234"), "Wrong output for \".234\"");

            Assert.AreEqual(true, Kata.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, Kata.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, Kata.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, Kata.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, Kata.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, Kata.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, Kata.ValidatePin("090909"), "Wrong output for \"090909\"");
        }

        [Test]
        [TestCase("asddsa", ExpectedResult = true)]
        [TestCase("a", ExpectedResult = false)]
        [TestCase("Hass", ExpectedResult = false)]
        [TestCase("Hasd_12ssssssssssssssasasasasasssasassss", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("____", ExpectedResult = true)]
        [TestCase("012", ExpectedResult = false)]
        [TestCase("p1pp1", ExpectedResult = true)]
        [TestCase("asd43 34", ExpectedResult = false)]
        [TestCase("asd43_34", ExpectedResult = true)]
        public static bool ValidateUserTest(string username)
        {
            return Kata.ValidateUsr(username);
        }

        [Test]
        public void IsEightBitNumberTest()
        {
            Assert.AreEqual(false, "".EightBitNumber());
            Assert.AreEqual(true, "0".EightBitNumber());
            Assert.AreEqual(false, "00".EightBitNumber());
            Assert.AreEqual(true, "55".EightBitNumber());
            Assert.AreEqual(false, "042".EightBitNumber());
            Assert.AreEqual(true, "123".EightBitNumber());
            Assert.AreEqual(true, "255".EightBitNumber());
            Assert.AreEqual(false, "256".EightBitNumber());
            Assert.AreEqual(false, "999".EightBitNumber());
            Assert.AreEqual(false, "-1".EightBitNumber());
        }

        [Test]
        public void IsSixBitNumberTest()
        {
            Assert.AreEqual(false, "".SixBitNumber());
            Assert.AreEqual(true, "0".SixBitNumber());
            Assert.AreEqual(false, "00".SixBitNumber());
            Assert.AreEqual(true, "55".SixBitNumber());
            Assert.AreEqual(true, "63".SixBitNumber());
            Assert.AreEqual(false, "64".SixBitNumber());
            Assert.AreEqual(false, "-0".SixBitNumber());
            Assert.AreEqual(false, "-5".SixBitNumber());
            Assert.AreEqual(false, "05".SixBitNumber());
            Assert.AreEqual(true, "5".SixBitNumber());
        }

        [Test]
        public void IsVowelTest()
        {
            Assert.AreEqual(false, "".IsVowel());
            Assert.AreEqual(true, "a".IsVowel());
            Assert.AreEqual(true, "E".IsVowel());
            Assert.AreEqual(false, "ou".IsVowel());
            Assert.AreEqual(false, "z".IsVowel());
            Assert.AreEqual(false, "lol".IsVowel());
        }

        [Test]
        [TestCase("abc", ExpectedResult = 3)]
        [TestCase("abcABC123", ExpectedResult = 3)]
        [TestCase("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 3)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 0)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", ExpectedResult = 26)]
        public static int CountLowercaseCharsTest(string str)
        {
            return Kata.LowercaseCountCheck(str);
        }

        [Test]
        [TestCase("123", ExpectedResult = true)]
        [TestCase("248", ExpectedResult = true)]
        [TestCase("8", ExpectedResult = false)]
        [TestCase("321", ExpectedResult = true)]
        [TestCase("9453", ExpectedResult = false)]
        public static bool StartsWith123Test(string code)
        {
            return Kata.StartsWith123(code);
        }

        [Test]
        public void ToCentsTest()
        {
            Assert.AreEqual(null, "".ToCents());
            Assert.AreEqual(null, "1".ToCents());
            Assert.AreEqual(null, "1.23".ToCents());
            Assert.AreEqual(null, "$1".ToCents());
            Assert.AreEqual(123, "$1.23".ToCents());
            Assert.AreEqual(9999, "$99.99".ToCents());
            Assert.AreEqual(1234567890, "$12345678.90".ToCents());
            Assert.AreEqual(969, "$9.69".ToCents());
            Assert.AreEqual(970, "$9.70".ToCents());
            Assert.AreEqual(971, "$9.71".ToCents());
            Assert.AreEqual(69, "$0.69".ToCents());
            Assert.AreEqual(null, "$9.69$4.3.7".ToCents());
            Assert.AreEqual(null, "$9.692".ToCents());
        }

        [Test]
        public void ToSecondsTest()
        {
            Assert.AreEqual(0, "00:00:00".ToSeconds());
            Assert.AreEqual(3723, "01:02:03".ToSeconds());
            Assert.AreEqual(null, "01:02:60".ToSeconds());
            Assert.AreEqual(null, "01:60:03".ToSeconds());
            Assert.AreEqual(359999, "99:59:59".ToSeconds());
            Assert.AreEqual(null, "0:00:00".ToSeconds());
            Assert.AreEqual(null, "00:0:00".ToSeconds());
            Assert.AreEqual(null, "00:00:0".ToSeconds());
            Assert.AreEqual(null, "00:00:00\n0".ToSeconds());
            Assert.AreEqual(null, "00\n00:00:00".ToSeconds());
        }
    }
}