using Day_20MoodAnalyser;
using Day_20MoodAnalyserTest;

namespace Day_20MoodAnalyserTest
{
    [TestClass]
    public class Test
    {
                       //USECASE-1
        [TestMethod]
        public void CheckSadMood()
        {

            //Arrange
            Day_20MoodAnalyser.MoodAnalyser1 moodAnalyser1 = new MoodAnalyser1("Iam in Sad Mood");


            //Act
            string checksadmood = moodAnalyser1.AnalyseMood();

            //Assert
            Assert.AreEqual("SAD", checksadmood);
        }
        [TestMethod]
        public void CheckHappyMood()
        {

            //Arrange
            MoodAnalyser1 moodAnalyser = new MoodAnalyser1("I am Mood");

            //Act
            string checkhappymood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY", checkhappymood);
        }
                                    //USECASE-2
        [TestMethod]
        public void CheckNullMood()
        {

            //Arrange
           
            NullMoodException nullMoodException = new NullMoodException(null);

            //Act
            string checknullmood = nullMoodException.ToString();


            //Assert
            Assert.AreNotEqual(null, checknullmood);
        }
                                     //USECASE-3
        [TestMethod]

        public void CheckInvalidMood()
        {

            //Arrange

            InvalidMoodException invalidMoodException = new InvalidMoodException(string.Empty);

            //Act
            string checkinvalidmood = invalidMoodException.ToString();


            //Assert
            Assert.AreNotEqual(null, checkinvalidmood);

        }
                                      //USECASE-4
        [TestMethod]
        public void CheckMoodREflection()
        {
            //Arrange
            MoodReflection moodReflection = new MoodReflection();

            //Act
            string checkmoodreflection = moodReflection.ToString();

            //Assert
            Assert.AreNotEqual(moodReflection, checkmoodreflection);
        }
                                   //USECASE-5
        [TestMethod]
        public void MoodAnalyserREflection()
        {
            //Arrange
            MoodAnalyseReflector moodAnalyseReflector = new MoodAnalyseReflector();

            //Act
            string checkmoodreflection = moodAnalyseReflector.ToString();

            //Assert
            Assert.AreNotEqual(moodAnalyseReflector, checkmoodreflection);
        }
                                 //USECASE-6
        [TestMethod]

        public void MoodChangeReflector()
        {
            //Arrange
            MoodChangeReflector moodChangeReflector = new MoodChangeReflector();

            //Act
            string checkchangereflector = moodChangeReflector.ToString();

            //Assert
            Assert.AreNotEqual(checkchangereflector, moodChangeReflector);
        }
    }  
}