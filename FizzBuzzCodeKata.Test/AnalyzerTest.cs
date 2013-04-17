using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzCodeKata.Library;
using NUnit.Framework;

namespace FizzBuzzCodeKata.Test
{
    public class AnalyzerTest
    {
        private Analyzer _analyzer;

        [SetUp]
        public void SetUp()
        {
            _analyzer = new Analyzer();
        }

        [Test]
        public void ShouldReturnFizzForMultiplesOfThree()
        {
            var expected = "Fizz";

            Assert.AreEqual(expected,_analyzer.Analyze(3));
            Assert.AreEqual(expected, _analyzer.Analyze(6));
            Assert.AreEqual(expected, _analyzer.Analyze(12));
        }

        [Test]
        public void ShouldReturnTheSameNumber()
        {            
            Assert.AreEqual("4", _analyzer.Analyze(4));
            Assert.AreEqual("19", _analyzer.Analyze(19));
            Assert.AreEqual("89", _analyzer.Analyze(89));
        }

        [Test]
        public void ShouldReturnBuzzForMultiplesOfFive()
        {
            var expected = "Buzz";

            Assert.AreEqual(expected, _analyzer.Analyze(5));
            Assert.AreEqual(expected, _analyzer.Analyze(10));
            Assert.AreEqual(expected, _analyzer.Analyze(20));
        }

        [Test]
        public void ShouldReturnFizzBuzzForMultiplesOfThreeAndFive()
        {
            var expected = "FizzBuzz";

            Assert.AreEqual(expected, _analyzer.Analyze(15));
            Assert.AreEqual(expected, _analyzer.Analyze(30));
            Assert.AreEqual(expected, _analyzer.Analyze(45));
        }

        [Test]
        public void ShouldReturnTheCompleteList()
        {
            var expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz\nFizz\n22\n23\nFizz\nBuzz\n26\nFizz\n28\n29\nFizzBuzz\n31\n32\nFizz\n34\nBuzz\nFizz\n37\n38\nFizz\nBuzz\n41\nFizz\n43\n44\nFizzBuzz\n46\n47\nFizz\n49\nBuzz\nFizz\n52\n53\nFizz\nBuzz\n56\nFizz\n58\n59\nFizzBuzz\n61\n62\nFizz\n64\nBuzz\nFizz\n67\n68\nFizz\nBuzz\n71\nFizz\n73\n74\nFizzBuzz\n76\n77\nFizz\n79\nBuzz\nFizz\n82\n83\nFizz\nBuzz\n86\nFizz\n88\n89\nFizzBuzz\n91\n92\nFizz\n94\nBuzz\nFizz\n97\n98\nFizz\nBuzz\n";

            Assert.AreEqual(expected,_analyzer.GetCompleteList());
        }
    }
}
