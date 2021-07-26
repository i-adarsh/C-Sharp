using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Sonu{
    public class Program{
        public string ChangeToCapitalization(string title){
            Regex r = new Regex("^[a-zA-Z ]+$");
            if (r.IsMatch(title)){
                String str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
                return str;
            }
            else
            return "Invalid input";
        }
        public static void Main(){
            Program p = new Program();
            Console.WriteLine("Enter the presentation title");
            string t = Console.ReadLine();
            Console.WriteLine(p.ChangeToCapitalization(t));
        }
    }
}
