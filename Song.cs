using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStaticClasses
{
    class Song
    {

        //our objects created from our Song class has these following properties
        public string title;
        public string artist;
        public int duration;


        //but this property applies to the entire class
        public static int songCount = 0;
        public static string label = "RockSteady";

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist; 
            duration = aDuration;
            songCount++;
            
        }

        public int getSongCount()
        {
            return songCount;
        }
        public string songLabel()
        {
            return songLabel();
        }
    }
}
