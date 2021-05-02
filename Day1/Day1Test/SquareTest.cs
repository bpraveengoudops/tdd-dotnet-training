using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Day1;


namespace Day1Test
{
    class SquareTest
    {
          
    [Test]
    public void testArea() 
    {
        Square square = new Square(3.0);
        Assert.AreEqual(9, square.area());
    }

    public void testAreaWithZero()
    {
        Square square = new Square(0.0);
        Assert.AreEqual(0.0, square.area());
    }


    public void testAreaWithOne()
    {
        Square square = new Square(1.0);
        Assert.AreEqual(1.0, square.area());
    }

       
  }
}
