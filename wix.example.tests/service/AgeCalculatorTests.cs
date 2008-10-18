using System;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using wix.example.exception;
using wix.example.service;

namespace wix.example.tests.service.AgeCalculator_Specs
{
    [TestFixture]
    public class When_calculating_a_users_age_and_current_date_is_past_current_year_birthday
    {
        private AgeCalculator calculator;
        private DateTime birthday;

        [SetUp]
        public void Setup()
        {
            birthday = new DateTime(1980, 7, 13);
            calculator = new AgeCalculator(birthday);
        }

        [Test]
        public void should_provide_correct_age()
        {
            Assert.That(calculator.RenderAge(), Is.GreaterThan(27));
        }
    }

    [TestFixture]
    public class When_calculating_a_users_age_and_current_date_is_before_year_birthday
    {
        private AgeCalculator calculator;
        private DateTime birthday;

        [SetUp]
        public void Setup()
        {
            birthday = DateTime.Now.AddMonths(1);
            calculator = new AgeCalculator(birthday);
        }

        [Test]
        [ExpectedException(typeof(InvalidBirthdayException))]
        public void should_provide_correct_age()
        {
            calculator.RenderAge();
        }
    }
}