﻿using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex09Test
    {
        [TestMethod]
        public void Ex09TestWithZero()
        {
            TestHelper.TestWithIO(typeof(Ex09), "0\r\n", 32.ToString());
        }

        [TestMethod]
        public void Ex09TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestWithIO(typeof(Ex09), n + "\r\n", (5 * n * n - 4 * n + 3).ToString());
        }

        [TestMethod]
        public void Ex09TestWithRandomNegativeNumber()
        {
            Random r = new Random();
            double n = r.Next(-100, -1);
            TestHelper.TestWithIO(typeof(Ex09), n + "\r\n", (5 * n * n - 4 * n + 3).ToString());
        }

    }
}
