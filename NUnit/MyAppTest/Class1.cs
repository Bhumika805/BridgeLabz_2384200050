using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyApp;

namespace MyAppTest
{
    [TestFixture]
    public class Class1
    {
        Calculator obj;

        [SetUp]
        public void setUp()
        {

            obj = new Calculator();

        }

        [Test]
        public void Test_add_MethodOfCalculatorClass()
        {
            Assert.That(obj.AddMethod(5,6), Is.EqualTo(11));
        }

        [TestCase(3,5,8)]
        [TestCase(4,5,9)]
        [TestCase(5,6,11)]
        [TestCase(6,7,13)]
        public void Test_AddMethod_With_Fourcases(int x,int y, int results)
        {
            Assert.That(obj.AddMethod(x,y), Is.EqualTo(results));
        }

        [Test]

        public void Test_sub_MethodOfCalculatorClass()
        {
            Assert.That(obj.SubtractMethod(4,3), Is.EqualTo(1));
        }

        [TestCase(8,5,3)]
        [TestCase(5,6,-1)]
        [TestCase(6,7,-1)]
        [TestCase(9,8,1)]
        public void Test_sub_MethodOfCalculatorClass(int x , int y , int result)
        {
            Assert.That(obj.SubtractMethod(x, y), Is.EqualTo(result));
        }

    }
}
