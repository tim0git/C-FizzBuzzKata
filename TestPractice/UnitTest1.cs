using NUnit.Framework;

namespace TestPractice
{
    public class Tests
    {
        /*[SetUp]
        public void Setup()
        {
        }*/

        //Not required for the test.

        [Test]
        public void Buzzer_When1_Returns1()
        {
            //Arrange
            int input = 1;

            //Act
            string output = FizzBuzz.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("1", output);
        }


        [Test]
        public void Buzzer_When3_Returns_Fizz()
        {
            //Arrange
            int input = 3;
            //Act
            string output = FizzBuzz.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When5_Returns_Buzz()
        {
            //Arrange
            int input = 5;
            //Act
            string output = FizzBuzz.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_When9_Returns_Fizz()
        {
            //Arrange
            int input = 9;
            //Act
            string output = FizzBuzz.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", output);
        }


        [Test]
        public void Buzzer_When10_Returns_Buzz()
        {
            //Arrange
            int input = 10;
            //Act
            string output = FizzBuzz.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("Buzz", output);
        }


        [Test]
        public void Buzzer_When12_Returns_Fizz()
        {
            //Arrange
            int input = 12;
            //Act
            string output = FizzBuzz.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When15_Returns_FizzBuzzer()
        {
            //Arrange
            int input = 15;
            //Act
            string output = FizzBuzz.Class1.GetValue(input);

            //Assert
            Assert.AreEqual("FizzBuzzer", output);
        }

        [Test]
        public void When_Passed_multiples_of_3_returns_Fizz()
        {
            //Arrange
            for(int i = 0; i<= 100; i++)
            {
                //Act
                string output = FizzBuzz.Class1.GetValue(i);

                if(i % 3 ==0 && i% 5 == 0)
                {
                   Assert.AreEqual("FizzBuzzer", output);
                } else if(i % 3 == 0)
                {
                    Assert.AreEqual("Fizz", output);
                } else if(i % 5 == 0)
                {
                    Assert.AreEqual("Buzz", output);
                }
                else
                {
                    Assert.AreEqual(i.ToString(), output);
                }
                //Assert
            }
        }



        // for all number between 0 and 100
        // if number is divisable by 3 returns fizz, if divisable by 5 returns buzz,
        // if divisbale by 5 & 3 return Fizzbuzzer
        // else return the number

        //[Test]
        // public void Array_Contains_Excatly_Two_Numbers_Greater_Than_1()
        //{
        //    Assert.That(array, Has.Exactly(2).GreaterThan(1));
        //}

        //[Test]
        // public void ArrayContainsExcatlyThreeNumbersLessThan100()
        //{
        //    Assert.That(array, Has.Exactly(3).LessThan(100));
        //}

        //[Test]
        //public void Four_and_Two_Plus_Two_Are_Equal()
        //{
        //    Assert.AreEqual(4, 2 + 2);
        //}

        //[Test]
        //public void Two_Plus_Two_Is_Equal_To_Four()
        //{
        //    Assert.That(2 + 2, Is.EqualTo(4));
        //}
    }
}