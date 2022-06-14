using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private readonly IEnumerable<Student> _StudentScore;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _StudentScore = ReadScore(filePath);
        }


        //得点データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(score);
            }
            return scores;
        }

        //科目別得点を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (Student sale in _StudentScore) {
                if (dict.ContainsKey(sale.Subject))
                    dict[sale.Subject] += sale.Score;
                else
                    dict[sale.Subject] = sale.Score;
            }
            return dict;
        }
    }
}
 
