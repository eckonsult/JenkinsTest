namespace ec.JenkinsTest.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ComplexTest
    {
        
        [Test]
        public void shouldAddTwoNumbers()
        {var c = new Complex{R=2,I=2};
            var complex = c+c;

            Assert.That(complex.R,Is.EqualTo(4));
            Assert.That(complex.I, Is.EqualTo(4));
        }

    }
}