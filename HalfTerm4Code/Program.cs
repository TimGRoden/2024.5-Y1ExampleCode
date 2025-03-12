using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_5_First_Year_Live_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MazeEntity obj1 = new MazeEntity(5);
            Console.WriteLine("Drawing MazeEntity:");
            obj1.Draw();

            MazePlayer obj2 = new MazePlayer(5);
            Console.WriteLine("Drawing MazePlayer:");
            obj2.Draw();

            MazeEnemy obj3 = new MazeEnemy(5);
            Console.WriteLine("Drawing MazeEnemy:");
            obj3.Draw();

            MazeEntity[] allThingsMazey = new MazeEntity[]
            {
                new MazeEntity(5),
                new MazePlayer(5),
                new MazeEnemy(5)
            };
            Console.WriteLine("Printing all 3 in the array:");
            for (int i = 0; i < allThingsMazey.Length; i++)
            { //Even when stored as 'MazeEntity', they use their own 'Draw' function
                (allThingsMazey[i]).Draw();
            }
            //Note: Without additional keywords, the new objects will always use their OWN '.Draw'
            Console.ReadKey();
        }
    }
}
