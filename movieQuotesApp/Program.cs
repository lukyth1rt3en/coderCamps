using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace movieQuotesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(3);
            var fileCollection = new string[3]
            {
                "http://www.wavsource.com/snds_2016-01-10_6357263721580594/tv/commercials/gray_poop.wav", "http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/misc/wayne_monkeys.wav", "http://www.wavsource.com/snds_2016-01-10_6357263721580594/sfx/boo.wav"
            };
            var Player = new SoundPlayer(fileCollection[random]);
            Player.Play();
            Console.ReadLine();

        }
    }
}