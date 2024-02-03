using NUnit.Framework;
using TennisGames;

namespace TennisUnitTests
{
    public class Tests
    { 

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void OneToThreehouldBeFifteenToThirty()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");

            var expected = "Fifteen Fourty";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);

            var actual = CurrentMatch.GetCurrentScore();


            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ZeroZeroShouldBeLoveLove()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "Love Love";
            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void PlayerOneWinsSet()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "left guy wins Set";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);


            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void PlayerTwoWinsSet()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "right guy wins Set";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);

            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void AdvantagePlayerTwo()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "Advantage right guy";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);

            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AdvantagePlayerOne()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "Advantage left guy";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(1);

            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void AdvantagePlayerOneAfterFivePoints()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "Advantage left guy";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);

            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);


            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);

            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DuceAfterFivePoints()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "Duce";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(1);

            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);
            CurrentMatch.PLayerScores(2);


            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FourFourShouldBeDuce()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "Duce";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void SameScoresShouldBeScoreAll()
        {
            var CurrentMatch = new TennisMatch("left guy", "right guy");
            var expected = "Fifteen All";

            CurrentMatch.PLayerScores(1);
            CurrentMatch.PLayerScores(2);

            var actual = CurrentMatch.GetCurrentScore();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}