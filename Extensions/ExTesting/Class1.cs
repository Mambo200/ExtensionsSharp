using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using String;
using List;

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
        public void ListTester1()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
            int last = intList.GetItemFromBack(-1);

            Assert.AreEqual(5, last);
        }
    }
}
