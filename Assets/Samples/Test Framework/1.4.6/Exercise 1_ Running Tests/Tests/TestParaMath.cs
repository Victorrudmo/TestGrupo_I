using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using MyExercise_1;

namespace Tests_Ejercicio1
{
    public class TestParaMath
    {
        [Test]
        public void SumaDosPositivos()
        {
            Assert.AreEqual(3, MyMath.Add(1, 2));
        }

        [Test]
        public void SumaPositivoNegarivo()
        {
            Assert.AreEqual(1, MyMath.Add(3, -2));
        }

        [Test]
        public void RestarDosPositivos()
        {
            Assert.AreEqual(3, MyMath.Subtract(5, 2));
        }

        [Test]
        public void RestarPositivoNegativo()
        {
            Assert.AreEqual(7, MyMath.Subtract(5, -2));
        }
    }

}
