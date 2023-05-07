namespace TestProject1
{
    public class Tests
    { 

        [Test]
        public void Test1()
        {
            string expected = "sad";
            string message = "sad";
            MoodAnalizer.moodAnalizer Analize = new MoodAnalizer.moodAnalizer(message);

            string mood = Analize.AnalizeMood();

            Assert.AreEqual(expected, mood);
        }
    }
}