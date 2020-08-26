using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;	
using System.Globalization;

namespace MiscLib
{
  public class GroupOneFunctions
  {
    //---- Group 1 Functions ----------

    public int CalcRectArea(int length, int width)
    {
            int RectArea;
            RectArea =  (length * width);
            return RectArea;
    }


    public bool IsFactiorialNum(int num)
    {
      ///need to wrap this in a while loop to exit at the else for a missed attempt
      for (int i = 1;; i++)  
      {  
          if (num % i == 0)  
          {  
            num /= i;  
          }  
          else
          {  
            break;
          }  
      } 
        if (num == 1)  
        {  
          return true;  
        }  
        else
        {  
          return false;  
        }   


    }


    public int CelciusToFarenheit(int celcius)
    { 
      return ((celcius * 9 / 5) + 32);
    } 



    public bool IsPalindrome(string word)
    {
      //think this is right - this removes all spaces and ingnores the capitals
        var temp1 = word.ToLower().Where(c => Char.IsLetter(c));
        var temp2 = word.ToLower().Reverse().Where(c => Char.IsLetter(c));
        return temp1.SequenceEqual(temp2);
    }

    public string StringReplace(string word, char replaceChar, char replacement)
    {
      string wordHolder;
      string toreplace = replaceChar.ToString();
      string replaceWith = replacement.ToString();

      if(word == null)
      {
        throw new System.ArgumentException("Parameter cannot be null", $"You entered { word }");
      }
      else
      {
        return wordHolder = Regex.Replace(word, toreplace, replaceWith, RegexOptions.IgnoreCase);
      }
      
    }

    public int CharCount(string word, char countCharacter)
    {
      string targetWord = word.ToLower();
		  char ch = char.ToLower(countCharacter);

      int freq = targetWord.Where(x => (x == ch)).Count();
      return freq;
      
    }


  }
}
