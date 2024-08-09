namespace CollatzConjecture.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateNumber_1()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(1);
            List<int> expected = new List<int>
            {
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_2()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(2);
            List<int> expected = new List<int>
            {
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_3()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(3);
            List<int> expected = new List<int>
            {
                3,
                10,
                5,
                16,
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_4()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(4);
            List<int> expected = new List<int>
            {
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_5()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(5);
            List<int> expected = new List<int>
            {
                5,
                16,
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_6()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(6);
            List<int> expected = new List<int>
            {
                6,
                3,
                10,
                5,
                16,
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_7()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(7);
            List<int> expected = new List<int>
            {
                7,
                22,
                11,
                34,
                17,
                52,
                26,
                13,
                40,
                20,
                10,
                5,
                16,
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_8()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(8);
            List<int> expected = new List<int>
            {
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        public void CalculateNumber_9()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(9);
            List<int> expected = new List<int>
            {
                9,
                28,
                14,
                7,
                22,
                11,
                34,
                17,
                52,
                26,
                13,
                40,
                20,
                10,
                5,
                16,
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_10()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(10);
            List<int> expected = new List<int>
            {
                10,
                5,
                16,
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void CalculateNumber_16()
        {
            List<int> result = CollatzConjectureProblem.CollatzConjecture.CalculateNumber(16);
            List<int> expected = new List<int>
            {
                16,
                8,
                4,
                2,
                1
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}