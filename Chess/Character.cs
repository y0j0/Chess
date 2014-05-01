using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class Character
    {
        public Character(int x, int y, CharacterType characterType)
        {
        }

        public int X { get; set; }
        public int Y { get; set; }

        public CharacterType Type { get; private set; }

        public PlayerType Player { get; private set; }

        public bool IsKilled { get; private set; }

        public abstract bool CanMove(int x, int y, Board board);
        
        public void Move(int x, int y)
        {
        }

        public void Kill();

        public void Draw();        
    }
}
