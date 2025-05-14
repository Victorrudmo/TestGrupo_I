using NUnit.Framework;
using MyExercise_2;

namespace Tests_2
{
    internal class StringFormatterTests
    {
        [Test]
        public void YourTestGoesHere()
        {
            
        }
        [Test]
        public void JoinsObjectsWithSemiColon()
        {
            // Arrange // PREPARACION
            var formatterUnderTest = new StringFormatter();
            formatterUnderTest.Configure(";");
            var objects = new object[] { "a", "bc", 5, "d" };

            // Act 77 RESULTADO
            var result = formatterUnderTest.Join(objects);

            // Assert // PRUEBA
            Assert.AreEqual("a;bc;5;d", result);
        }

    }
}