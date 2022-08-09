using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStaticClasses
{
    class Program
    {


        //here is our main method
        static void Main(string[] args)
        {

            //Song is the class that we created that has the constructor method that allows us to assign values to the properties of these objects like this

            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.label);
            //getSongCount is another method we made in our Song.cs file
            //the static attribute allows us to assign a value such as the song count to everything inside the class as opposed to the individual objects in the class
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());

            

            Console.ReadLine();


        }
    }
}