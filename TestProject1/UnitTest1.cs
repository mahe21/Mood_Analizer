using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    public class Tests
    { 

        [TestMethod]
        [DataRow(null)]
        public void Test1(string message)
        {
            string expected = "happy";
            MoodAnalizer.moodAnalizer Analize = new MoodAnalizer.moodAnalizer(message);

            string mood = Analize.AnalizeMood();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, mood);
        }
    }
}