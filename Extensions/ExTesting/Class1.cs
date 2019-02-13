using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using IntExtensions;
using ListExtensions;
using ArrayExtensions;

namespace ExTesting
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void StringTester1()
        {
            string s = "Hallabbakko";
            s = s.RemoveChars('a', 'o');
            Assert.AreEqual(s, "Hllbbkk");
        }
    }

    [TestClass]
    public class IntTest
    {

    }

    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void ListTester1_GetItemFromBack()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
            int last = intList.GetItemFromBack(-1);
            last = intList.GetItemFromBack(-1);
            Assert.AreEqual(5, last);
        }

        [TestMethod]
        public void ListTester2_RemoveAt()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };

            intList.RemoveAt(0);

            Assert.AreEqual(intList[0], 2);
            Assert.AreEqual(intList[1], 3);
            Assert.AreEqual(intList[2], 4);
            Assert.AreEqual(intList[3], 5);

        }
    }
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void ArrayTester1()
        {
            int[] intArray = new int[] { 0, 1, 2, 3, 4, 5 };
        }
    }
}
