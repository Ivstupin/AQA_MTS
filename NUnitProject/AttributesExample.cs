﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    public class AttributesExample
    {
        private int x;
        private int y;
        private int i;

        [Test(Description = "Test for Math Operation")]
        public void Demotest()
        {
            Console.WriteLine($"{this}: Demotest...{x++}");
        }

        [Test, Category("Smoke")]
        public void BigTest()
        {
            Console.WriteLine($"{this}: BigTest...{x++}");
        }

        [Test, Ignore("Ignoring this test due Issue")]


        public void AlphaTest()
        {
            Console.WriteLine($"{this}: AlphaTest...{x++}");
        }

        [Test, Order(1)]
        public void ZTest()
        {
            Console.WriteLine($"{this}: ZTest...{x++}");
        }

        [Test, Order(2)]
        public void XTest()
        {
            Console.WriteLine($"{this}: XTest...{x++}");
        }

        [Test, Order(2)]
        //[Author("Jane Doe, "jane.doe@example.com")]
        public void AuthorTest()
        {
            Console.WriteLine($"{this}: AuthorTest...{x++}");

        }

        [Test]
        [Repeat(5)]
        public void RepeatTest()
        {
            Console.WriteLine($"{this}: RepeatTest...{x++}");
        }

        [Test]
        [Repeat(3)]
        public void RetryTest()
        {
            Console.WriteLine($"{this}: RetryTest...{++i}");
            if (i == 4) Assert.Pass();
            else Assert.Fail();
        }

        [Test, MaxTime(2000)]
        public void TimedTest()
        {
            Thread.Sleep(2000);
        }

        [Test]
        public void RandomValueTest([Random(1,10,5)]int randomNumber)
        {
            Console.WriteLine($"{this}: RandomValuesTest...{randomNumber}{x++}");
        }

        [Test]
        public void RangeValueTest([Random(1, 10, 5)]int rangeNumber)
        {
            Console.WriteLine($"{this}: RandomValuesTest...{rangeNumber}{x++}");
        }

        [Test]
        public void ValueTest([Values(1, 5, 2)] int valuesNumber)
        {
            Console.WriteLine($"{this}: RandomValuesTest...{valuesNumber}{x++}");
        }

    [Test]
    public void AllValueTest(
        [Random(1, 10, 5)] int randomNumber,
        [Random(1, 10, 5)] int rangeNumber,
        [Values(1, 5, 2)] int valuesNumber)
    {
        Console.WriteLine($"{this}: RandomValuesTest...{randomNumber}{x++}");
            Console.WriteLine($"{this}: RandomValuesTest...{rangeNumber}{x++}");
            Console.WriteLine($"{this}: RandomValuesTest...{valuesNumber}{x++}");
        }

        [Test, Combinatorial]
        public void CombinatorialTest(
        [Values(1, 10, 5)] int randomNumber,
        [Values("A","B")] string  text)
        {
            Console.WriteLine($"{text} {1} {2}");
        }

        [Test, Pairwise]
        public void PairwiseTest(
                [Values("a", "b", "c")] string a,
            [Values("+", "-")] string b,
            [Values("x", "y")] string c)
                {
            Console.WriteLine($"{0} {1} {2}", a , b , c );
        }

        //property
        [Test]
        [Property("Severity", "Critical")]
        public void PropertyTest()
        {
            Console.WriteLine($"{this}: PropertyTest...{TestContext.CurrentContext.Test.Properties.Get("Severity")}");
        }

        [Test]
        [Severity(SeverityLevel.Minor)]
        public void AdvancePropertyTest()
        {
            Console.WriteLine($"{this}: PropertyTest...{TestContext.CurrentContext.Test.Properties.Get("Severity")}");
        }



    }
}
