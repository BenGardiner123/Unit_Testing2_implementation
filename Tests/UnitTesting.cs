using System;
using Xunit;
using MiscLib;

namespace Test
{
  public class UnitTesting
  {
    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(2, -4, 8)] //Negative Check
    [InlineData(0, -4, 8)] //Zero Check
    public void CalcRectArea_Test(int length, int width, int result)
    {
      var test = new GroupOneFunctions();
      //Negative numbers produce a exception
      if (length < 0 || width < 0)
      {
        Assert.Throws<Exception>(() => test.CalcRectArea(length, width));
      }
      else
      {
        Assert.Equal(result, test.CalcRectArea(length, width));
      }
    }

    [Theory]
    [InlineData(24, true)]
    [InlineData(-6, false)]
    [InlineData(6, true)]
    [InlineData(4, false)]
    public void IsFactiorialNum_Test(int num, bool result)
    {
      var test = new GroupOneFunctions();
      Assert.Equal(result, test.IsFactiorialNum(num));
    }

    [Theory]
    [InlineData(13, 55)]
    [InlineData(-13, 9)]
    public void CelciusToFarenheit_Test(int num, int result)
    {
      var test = new GroupOneFunctions();
      Assert.Equal(result, test.CelciusToFarenheit(num));
    }


    [Theory]
    [InlineData("kayak", true)]
    [InlineData("Kayak", true)] //Capitalisation
    [InlineData("yo banana boy", true)] //Spaces
    [InlineData("Palindrome", false)]
    public void IsPalindrome_Test(string str, bool result)
    {
      var test = new GroupOneFunctions();
      Assert.Equal(result, test.IsPalindrome(str));
    }


    [Theory]
    [InlineData("this is a string", 'i', 'x', "thxs xs a strxng")]
    [InlineData("thIs is a strIng", 'i', 'x', "thxs xs a strxng")] //Capitalisation.
    [InlineData("this is a string", 'w', 'x', "this is a string")]
    [InlineData("", 'i', 'x', "")]
    public void StringReplace_Test(string str, char targetChar, char replacementChar, string result)
    {
      var test = new GroupOneFunctions();
      Assert.Equal(result, test.StringReplace(str, targetChar, replacementChar));
    }


    [Theory]
    [InlineData("this is a string", 'i', 3)]
    [InlineData("thIs is a strIng", 'i', 3)] //Capitalisation.
    [InlineData("this is a string", 'w', 0)]
    [InlineData("", 'i', 0)] //String with 0 length.
    public void CharCount_Test(string str, char character, int result)
    {
      var test = new GroupOneFunctions();
      Assert.Equal(result, test.CharCount(str, character));
    }
  }
}
