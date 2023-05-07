
using MoodAnalizer;

namespace TestProject1
{
    public class Tests
    { 

        [Test]
        public void Test1()
        {
            try
            {
                string message = "";
                MoodAnalizer.moodAnalizer Analize = new MoodAnalizer.moodAnalizer(message);
                string mood = Analize.AnalizeMood();
            }
            catch (AnalizerException e)
            {
                Assert.AreEqual("message must not be empty", e.Message);
            }
            
        }
        [Test]
        public void Test2()
        {
            try
            {
                string message = null;
                MoodAnalizer.moodAnalizer Analize = new MoodAnalizer.moodAnalizer(message);
                string mood = Analize.AnalizeMood();
            }
            catch (AnalizerException e)
            {
                Assert.AreEqual("message should not be null", e.Message);
            }

        }
    }
}