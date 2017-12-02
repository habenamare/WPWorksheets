using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WPWorksheets.Tests {

    [TestClass]
    public class Worksheet2Tests {

        // integer array to be checked as Key and
        // expected result as Value
        private Dictionary<int[], int> isSortedTestArrays = new Dictionary<int[], int>() {
            { new int[] { 1, 2, 5, 6 },  1 },
            { new int[] { 12, 3, 2, 1 }, 1 },
            { new int[] { 1, 2, 6, 3 },  0 },
            { new int[] { },             1 },
            { new int[] { 2 },           1 }
        };

        [TestMethod]
        public void IsSortedTest() {
            // check integer arrays with associated integer values using IsSorted
            foreach (KeyValuePair<int[], int> test in isSortedTestArrays) {
                Assert.AreEqual(test.Value, Worksheet2.IsSorted(test.Key));
            }
        }

        [TestMethod]
        public void IsSorted2Test() {
            // check integer arrays with associated integer values using IsSorted2
            foreach (KeyValuePair<int[], int> test in isSortedTestArrays) {
                Assert.AreEqual(test.Value, Worksheet2.IsSorted2(test.Key));
            }
        }

    }


}
