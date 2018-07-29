using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test591TagValidator
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV></DIV>");
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV>This is the first line <![CDATA[<div>]]></DIV>");
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV>>>  ![cdata[]] <![CDATA[<div>]>]]>]]>>]</DIV>");
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<A>  <B> </A>   </B>");
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV>  div tag is not closed  <DIV>");
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV>  unmatched <  </DIV>");
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void TestMethod7()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV> closed tags with invalid tag name <b>123</b> </DIV>");
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void TestMethod8()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV> unmatched tags with invalid tag name  </1234567890> and <CDATA[[]]>  </DIV>");
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void TestMethod9()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<DIV>  unmatched start tag <B>  and unmatched end tag </C>  </DIV>");
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void TestMethod10()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<A><A>456</A>  <A> 123  !!  <![CDATA[]]>  123 </A>   <A>123</A></A>");
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void TestMethod11()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<A><B><![CDATA[></B>]]></A>");
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void TestMethod12()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<A><A>/A></A></A>");
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void TestMethod13()
        {
            var test = new _591TagValidator();
            var valid = test.IsValid("<b><aaaaaaaaaa></aaaaaaaaaa></b>");
            Assert.AreEqual(false, valid);
        }
    }
}
