using DaysOfCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCodeTests
{
    [TestClass]
    public class DaysOfCodeTests
    {
        [TestMethod]
        public void SwapEndsTest()
        {
            Day01Code day1Code = new Day01Code();
            CollectionAssert.AreEqual(new int[] { 4, 2, 3, 1 }, day1Code.SwapEnds(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, day1Code.SwapEnds(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 8, 6, 7, 9, 5 }, day1Code.SwapEnds(new int[] { 5, 6, 7, 9, 8 }));
        }

        [TestMethod]
        public void Has12Test()
        {
            Day02Code day2Code = new Day02Code();
            Assert.AreEqual(true, day2Code.Has12(new int[] { 1, 3, 2 }));
            Assert.AreEqual(true, day2Code.Has12(new int[] { 3, 1, 2 }));
            Assert.AreEqual(true, day2Code.Has12(new int[] { 3, 1, 4, 5, 2 }));
            Assert.AreEqual(false, day2Code.Has12(new int[] { 2, 3, 1, 5, 4 }));
        }

        [TestMethod]
        public void GreenTicketTest()
        {
            Day03Code day3Code = new Day03Code();
            Assert.AreEqual(0, day3Code.GreenTicket(1, 2, 3));
            Assert.AreEqual(20, day3Code.GreenTicket(2, 2, 2));
            Assert.AreEqual(10, day3Code.GreenTicket(1, 2, 1));
        }

        [TestMethod]
        public void Start1Test()
        {
            Day04Code day4Code = new Day04Code();
            Assert.AreEqual(2, day4Code.Start1(new int[] { 1, 2, 3 }, new int[] { 1, 5 }));
            Assert.AreEqual(1, day4Code.Start1(new int[] { 5, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(0, day4Code.Start1(new int[] { 3, 2 }, new int[] { 4, 5, 6, 7 }));
        }

        [TestMethod]
        public void FizzArry3Test()
        {
            Day05Code day5Code = new Day05Code();
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8, 9 }, day5Code.FizzArray3(5, 10));
            CollectionAssert.AreEqual(new int[] { 11, 12, 13, 14, 15, 16, 17 }, day5Code.FizzArray3(11, 18));
            CollectionAssert.AreEqual(new int[] { 1, 2 }, day5Code.FizzArray3(1, 3));
            CollectionAssert.AreEqual(new int[] { }, day5Code.FizzArray3(1, 1));
            CollectionAssert.AreEqual(new int[] { }, day5Code.FizzArray3(1, -5));
        }

        [TestMethod]
        public void Only14Test()
        {
            Day06Code day6Code = new Day06Code();
            Assert.AreEqual(true, day6Code.Only14(new int[] { 1, 4, 1, 4 }));
            Assert.AreEqual(false, day6Code.Only14(new int[] { 1, 4, 2, 4 }));
            Assert.AreEqual(true, day6Code.Only14(new int[] { 1, 1 }));
            Assert.AreEqual(true, day6Code.Only14(new int[] { 4, 4 }));
        }

        [TestMethod]
        public void NoTuplesTest()
        {
            Day07Code day7Code = new Day07Code();
            Assert.AreEqual(true, day7Code.NoTuples(new int[] { 1, 1, 2, 2, 1 }));
            Assert.AreEqual(false, day7Code.NoTuples(new int[] { 1, 1, 2, 2, 2, 1 }));
            Assert.AreEqual(false, day7Code.NoTuples(new int[] { 1, 1, 1, 2, 2, 2, 1 }));
        }
        [TestMethod]
        public void No23Test()
        {
            Day08Code day8Code = new Day08Code();
            Assert.AreEqual(true, day8Code.No23(new int[] { 4, 5 }));
            Assert.AreEqual(false, day8Code.No23(new int[] { 4, 2 }));
            Assert.AreEqual(false, day8Code.No23(new int[] { 3, 5 }));
        }

        [TestMethod]
        public void PlusTwoTest()
        {
            Day09Code day9Code = new Day09Code();
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, day9Code.PlusTwo(new int[] { 1, 2}, new int[] { 3, 4}));
            CollectionAssert.AreEqual(new int[] { 4, 4, 2, 4 }, day9Code.PlusTwo(new int[] { 4, 4 }, new int[] { 2, 4 }));
            CollectionAssert.AreEqual(new int[] { 9, 2, 3, 4 }, day9Code.PlusTwo(new int[] { 9, 2 }, new int[] { 3, 4 }));
        }

        [TestMethod]
        public void More14Test()
        {
            Day10Code day10Code = new Day10Code();
            Assert.AreEqual(true, day10Code.More14(new int[] { 1, 4, 1 }));
            Assert.AreEqual(false, day10Code.More14(new int[] { 1, 4, 1, 4 }));
            Assert.AreEqual(true, day10Code.More14(new int[] { 1, 1 }));
        }

        [TestMethod]
        public void MakeMiddleTest()
        {
            Day11Code day11Code = new Day11Code();
            CollectionAssert.AreEqual(new int[] { 2, 3 }, day11Code.MakeMiddle(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 2, 3 }, day11Code.MakeMiddle(new int[] { 7, 1, 2, 3, 4, 9 }));
            CollectionAssert.AreEqual(new int[] { 1, 2 }, day11Code.MakeMiddle(new int[] { 1, 2 }));
        }

        [TestMethod]
        public void MakeLastTest()
        {
            Day12Code day12Code = new Day12Code();
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 6 }, day12Code.MakeLast(new int[] { 4, 5, 6 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 2 }, day12Code.MakeLast(new int[] { 1, 2 }));
            CollectionAssert.AreEqual(new int[] { 0, 3 }, day12Code.MakeLast(new int[] { 3 }));
        }

        [TestMethod]
        public void MakeEndsTest()
        {
            Day13Code day13Code = new Day13Code();
            CollectionAssert.AreEqual(new int[] { 1, 3 }, day13Code.MakeEnds(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 1, 4 }, day13Code.MakeEnds(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 7, 2 }, day13Code.MakeEnds(new int[] { 7, 4, 6, 2 }));
        }

        [TestMethod]
        public void LessBy10Test()
        {
            Day14Code day14Code = new Day14Code();
            Assert.IsTrue(day14Code.LessBy10(1, 7, 11));
            Assert.IsFalse(day14Code.LessBy10(1, 7, 10));
            Assert.IsTrue(day14Code.LessBy10(11, 1, 7));
        }
    }
}
