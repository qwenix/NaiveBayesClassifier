using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BayesSpamFiltering.Models {
    public static class AppExtensions {

        private static readonly char[] ALLOWED_DELIMITERS = 
            new[] { '-', '`', '\'', '’' };

        public static bool IsAllowed(this char c) {
            return char.IsLetter(c) || ALLOWED_DELIMITERS.Contains(c); 
        }

        public static List<string> GetFeatures(this string text) {
            var r = new List<string>();
            for (int i = 0; i < text.Length; i++) {
                if (char.IsLetter(text[i])) {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(text[i]);

                    int j = i + 1;
                    while (j < text.Length && text[j].IsAllowed()) {
                        sb.Append(text[j++]);
                    }

                    string word = sb.ToString().ToUpper();
                    r.Add(word);

                    i = j;
                }
            }
            return r;
        }
    }
}
