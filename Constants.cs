using System.Collections.Generic;

namespace NoMoreConsole
{
    public class Constants
    {
        
        static Constants()
        {
            List<string> list = new List<string>();
            list.Add("https://iidk.online/");
            list.Add("https://raw.githubusercontent.com/iiDk-the-actual/Console");
            list.Add("https://data.hamburbur.org");
            list.Add("https://files.hamburbur.org");
            list.Add("https://raw.githubusercontent.com/iiDk-the-actual/Console/refs/heads/master/SafeLua");
            list.Add("https://raw.githubusercontent.com/iiDk-the-actual/Console/refs/heads/master/ServerData");
            Constants.BlockedUrls = list;
        }

        public static List<string> BlockedUrls;
    }
} 
