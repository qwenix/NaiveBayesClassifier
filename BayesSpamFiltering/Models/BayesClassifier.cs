using System;
using System.Collections.Generic;
using System.Linq;

namespace BayesSpamFiltering.Models {

    public class BayesClassifier {
        private List<ClassInfo> classes;
        private int documentsCount;
        private int wordsCount;

        public BayesClassifier(List<Document> train) {
            classes = train.GroupBy(x => x.Class)
                .Select(g => new ClassInfo(g.Key, g.Select(x => x.Text).ToList()))
                .ToList();

            documentsCount = train.Count;
            wordsCount = train.SelectMany(x => x.Text.GetFeatures())
                .GroupBy(x => x)
                .Count();
        }

        public object[] WordsReport {
            get {
                var r = new [] { 
                    new { Word = "", Class = "", Count = 0 } 
                }.AsEnumerable();
                foreach (ClassInfo c in classes) {
                    r = r.Concat(c.WordCount.Select(w => 
                    new { Word = w.Key, Class = c.Name, Count = w.Value }));
                }
                return r.Skip(1).OrderByDescending(x => x.Count).ToArray();
            }
        }

        public IEnumerable<KeyValuePair<string, int>> GetTop(string className, int limit) {
            return classes.First(c => c.Name == className).WordCount
                .Take(limit).OrderByDescending(x => x.Value);
        }

        public int GetWordsCount(string className) {
            return classes.First(c => c.Name == className).WordsCount;
        } 

        public double Test(string className, string text) {
            var words = text.GetFeatures();
            var classResults = classes
                .Select(x => new {
                    Result = Math.Pow(Math.E, Calculate(x.NumberOfDocs, 
                        documentsCount, words, x.WordsCount, x, wordsCount)),
                    ClassName = x.Name
                });

            return classResults.Single(x => x.ClassName == className).Result / 
                classResults.Sum(x => x.Result);
        }

        private static double Calculate(double dc, double d, List<string> q, 
            double lc, ClassInfo classInfo, double v) {
            return Math.Log(dc / d, 10e7) + q.Sum(x => 
                Math.Log((classInfo.NumberOfOccurencesInTrainDocs(x) + 1) / (v + lc), 10e7));
        }
    }

    public class Document {
        public Document(string className, string text) {
            Class = className;
            Text = text;
        }

        public string Class { get; set; }
        public string Text { get; set; }
    }

    public class ClassInfo {
        public ClassInfo(string name, List<string> trainDocs) {
            Name = name;

            var features = trainDocs.SelectMany(x => x.GetFeatures());

            WordsCount = features.Count();
            WordCount = features.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());
            NumberOfDocs = trainDocs.Count;
        }

        public string Name { get; set; }
        public int WordsCount { get; set; }
        public int NumberOfDocs { get; set; }
        public Dictionary<string, int> WordCount { get; set; }


        public int NumberOfOccurencesInTrainDocs(string word) {
            if (WordCount.Keys.Contains(word))
                return WordCount[word];
            return 0;
        }
    }
}
