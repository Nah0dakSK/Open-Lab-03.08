using System;

namespace Open_Lab_03._08
{
    public class Checker
    {
        public bool IsPlural(string word)
        {
            if(word.EndsWith("s"))
                return true;
            if(word.EndsWith("ies"))
                return true;
            if(word.EndsWith("es"))
                return true;
            if(word.EndsWith("uses"))
                return true;
            if(word.EndsWith("ses"))
                return true;
            if(word.EndsWith("ves"))
                return true;
            if(word.EndsWith("ices"))
                return true;
            else 
                return false;
        }
    }
}
