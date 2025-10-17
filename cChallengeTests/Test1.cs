using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cChallenge;

namespace cChallengeTests
{
    [TestClass]
    public class OldPhonePadTests
    {
        [TestMethod]
        public void OldPhonePad_GivenTestCases() // Test cases provided in the prompt
        {
            Assert.AreEqual("E", cChallenge.Program.OldPhonePad("33#"));
            Assert.AreEqual("B", cChallenge.Program.OldPhonePad("227*#"));
            Assert.AreEqual("HELLO", cChallenge.Program.OldPhonePad("4433555 555666#"));
            Assert.AreEqual("TURING", cChallenge.Program.OldPhonePad("8 88777444666*664#"));
            Assert.AreEqual("HELLO WORLD", cChallenge.Program.OldPhonePad("4433555 555666 096667775553#"));
        }

        [TestMethod]
        public void OldPhonePad_SingleNumbers() // Test cases for single key presses
        {
            Assert.AreEqual("&", cChallenge.Program.OldPhonePad("1#"));
            Assert.AreEqual("A", cChallenge.Program.OldPhonePad("2#"));
            Assert.AreEqual("D", cChallenge.Program.OldPhonePad("3#"));
            Assert.AreEqual("G", cChallenge.Program.OldPhonePad("4#"));
            Assert.AreEqual("J", cChallenge.Program.OldPhonePad("5#"));
            Assert.AreEqual("M", cChallenge.Program.OldPhonePad("6#"));
            Assert.AreEqual("P", cChallenge.Program.OldPhonePad("7#"));
            Assert.AreEqual("T", cChallenge.Program.OldPhonePad("8#"));
            Assert.AreEqual("W", cChallenge.Program.OldPhonePad("9#"));
        }

        [TestMethod]
        public void OldPhonePad_DoubleNumbers() // Test cases for double key presses
        {
            Assert.AreEqual("'", cChallenge.Program.OldPhonePad("11#"));
            Assert.AreEqual("B", cChallenge.Program.OldPhonePad("22#"));
            Assert.AreEqual("E", cChallenge.Program.OldPhonePad("33#"));
            Assert.AreEqual("H", cChallenge.Program.OldPhonePad("44#"));
            Assert.AreEqual("K", cChallenge.Program.OldPhonePad("55#"));
            Assert.AreEqual("N", cChallenge.Program.OldPhonePad("66#"));
            Assert.AreEqual("Q", cChallenge.Program.OldPhonePad("77#"));
            Assert.AreEqual("U", cChallenge.Program.OldPhonePad("88#"));
            Assert.AreEqual("X", cChallenge.Program.OldPhonePad("99#"));
        }

        [TestMethod]
        public void OldPhonePad_TripleNumbers() // Test cases for triple key presses
        {
            Assert.AreEqual("(", cChallenge.Program.OldPhonePad("111#"));
            Assert.AreEqual("C", cChallenge.Program.OldPhonePad("222#"));
            Assert.AreEqual("F", cChallenge.Program.OldPhonePad("333#"));
            Assert.AreEqual("I", cChallenge.Program.OldPhonePad("444#"));
            Assert.AreEqual("L", cChallenge.Program.OldPhonePad("555#"));
            Assert.AreEqual("O", cChallenge.Program.OldPhonePad("666#"));
            Assert.AreEqual("R", cChallenge.Program.OldPhonePad("777#"));
            Assert.AreEqual("V", cChallenge.Program.OldPhonePad("888#"));
            Assert.AreEqual("Y", cChallenge.Program.OldPhonePad("999#"));
        }

        [TestMethod]
        public void OldPhonePad_QuadrupleNumbers() // Test cases for quadruple key presses
        {
            Assert.AreEqual("S", cChallenge.Program.OldPhonePad("7777#"));
            Assert.AreEqual("Z", cChallenge.Program.OldPhonePad("9999#"));
        }

        [TestMethod]
        public void OldPhonePad_SpecialCases() // Test cases for special characters and edge cases
        {
            Assert.AreEqual(" ", cChallenge.Program.OldPhonePad("0#"));
            Assert.AreEqual("", cChallenge.Program.OldPhonePad("#"));
            Assert.AreEqual("", cChallenge.Program.OldPhonePad("1"));
            Assert.AreEqual("", cChallenge.Program.OldPhonePad("111"));
            Assert.AreEqual("", cChallenge.Program.OldPhonePad("1122"));
            Assert.AreEqual("", cChallenge.Program.OldPhonePad("asd#")); 
            Assert.AreEqual("&AD&AD", cChallenge.Program.OldPhonePad("123asd123#"));
            Assert.AreEqual("P", cChallenge.Program.OldPhonePad("77777#")); 
            Assert.AreEqual("T", cChallenge.Program.OldPhonePad("8888#"));
            Assert.AreEqual("W", cChallenge.Program.OldPhonePad("99999#"));

        }
    }
}
