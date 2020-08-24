using System;
using System.Linq;
using System.Collections.Generic;	

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


   /*  public int CelciusToFarenheit(int celcius)
    {
      
      //return ((9.0 / 5.0) * celcius) + 32;
    } */



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
      
      return wordHolder = word.Replace(replaceChar, replacement);
    
    }

    public int CharCount(string word, char countCharacter)
    {
      string targetWord = word;
		  char ch = countCharacter;

      int freq = targetWord.Where(x => (x == ch)).Count();
      return freq;
      
    }


  }
}
