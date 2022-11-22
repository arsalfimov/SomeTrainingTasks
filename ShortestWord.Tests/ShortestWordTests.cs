using NUnit.Framework;

namespace ShortestWord.Tests
{
    [TestFixture]
    public class ShortestWordTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"), Is.EqualTo(3));
            Assert.That(ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"), Is.EqualTo(3));
            Assert.That(ShortestWord.FindShort("lets talk about javascript the best language"), Is.EqualTo(3));
            Assert.That(ShortestWord.FindShort("i want to travel the world writing code one day"), Is.EqualTo(1));
            Assert.That(ShortestWord.FindShort("Lets all go on holiday somewhere very cold"), Is.EqualTo(2));
            Assert.That(ShortestWord.FindShort("Let's travel abroad shall we"), Is.EqualTo(2));
        }

        [Test]
        public void RandomTests()
        {
            var rand = new Random();
            var names = new[] { "Bitcoin", "LiteCoin", "Ripple", "Dash", "Lisk", "DarkCoin", "Monero", "Ethereum", "Classic", "Mine", "ProofOfWork", "ProofOfStake", "21inc", "Steem", "Dogecoin", "Waves", "Factom", "MadeSafeCoin", "BTC" };


            for (var i = 0; i < 40; i++)
            {
                var s = string.Join(" ", Enumerable.Range(0, rand.Next(1, 20)).Select(a => names[rand.Next(0, names.Length)]));

                var expected = s.Split(' ').Select(w => w.Length).Min();

                Assert.That(ShortestWord.FindShort(s), Is.EqualTo(expected), "It should work for random inputs too");
            }
        }
    }
}