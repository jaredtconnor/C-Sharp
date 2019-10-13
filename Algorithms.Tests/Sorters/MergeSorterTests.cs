﻿using System;
using Algorithms.Sorters;
using Algorithms.Tests.Helpers;
using NUnit.Framework;

namespace Algorithms.Tests.Sorters
{
    /// <summary>
    /// Class for testing merge sorter algorithm.
    /// </summary>
    public static class MergeSorterTests
    {
        [Test]
        public static void TestOnMergeSorter([Random(0, 1000, 100, Distinct = true)]int n)
        {
            // Arrange 
            var sorter = new MergeSorter<int>();
            var intComparer = new IntComparer();
            var (correctArray, testArray) = RandomHelper.GetArrays(n);

            // Act
            sorter.Sort(testArray, intComparer);
            Array.Sort(correctArray);

            // Assert
            Assert.AreEqual(correctArray, testArray);
        }
    }
}