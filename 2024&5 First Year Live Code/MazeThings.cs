using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_5_First_Year_Live_Code
{
    public class MazeEntity
    {
        protected int maxMoves, movesLeft;
        public MazeEntity(int MaxIn) {
            maxMoves = MaxIn; movesLeft = MaxIn;
        }
        public bool Move(int distance)
        {
            if (distance > movesLeft) return false;

            movesLeft -= distance;
            return true;
        }
        public virtual bool Draw()
        {
            Console.WriteLine("O");
            return true;
        }
    }
    public class MazePlayer : MazeEntity
    {
        private int hitPoints;
        public MazePlayer(int hp) : base(20)
        {
            hitPoints = hp;
        }
        public override bool Draw()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine('X');
            Console.ForegroundColor = ConsoleColor.Gray;
            return true;
        }
    }
    public class MazeEnemy : MazeEntity
    {
        private int hitPoints;
        public MazeEnemy(int hp) : base(10)
        {
            hitPoints = hp;
        }
        public override bool Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            bool success = base.Draw();

            Console.ForegroundColor = ConsoleColor.Gray;
            return success;
        }
    }
}
