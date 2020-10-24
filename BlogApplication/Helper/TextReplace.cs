using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApplication.Helper
{
    public class TextReplace
    {
        public static string Replace(string Text)
        {
            Text = Text.Replace(' ', '-');
            Text = Text.Replace('.', '-');
            Text = Text.Replace("?", string.Empty);
            Text = Text.Replace('Ü', 'u');
            Text = Text.Replace('ü', 'u');
            Text = Text.Replace('ç', 'c');
            Text = Text.Replace('ş', 's');
            Text = Text.Replace('I', 'i');
            Text = Text.Replace('ı', 'i');
            Text = Text.Replace('ğ', 'g');
            Text = Text.Replace("-", string.Empty);

            return Text;
        }
    }
}