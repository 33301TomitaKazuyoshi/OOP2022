using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            //Songクラスのインスタンスを複数作成し、配列songsに格納            
            var songs = new Song[] {
                new Song("abc","tom",300),
                new Song("def","ito",300),
                new Song("ghi","mij",300)
            };

            /*リストを用いた書き方
             List<Song> songs = new List<Song>();
             
             var song1 = new Song("a","a_man",300);
             songs.Add(song1);
             var song2 = new Song("b","b_men",300);
             songs.Add(song2);
             var song3 = new Song("c","c_gay",300);
             songs.Add(song3);
             
             */

            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2:m\\:ss}", //書式を設定
                    song.Title, song.ArtistName,TimeSpan.FromSeconds(song.Length)); //出力
            }
        }
    }
}
