using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {

        public void Draw()
        {        
        }        
        
        public List<Character> Characters { get; set; }

        public void DoMove(Character character, int x, int y)
        {
        }

        public bool IsChessMat()
        {
            return false;
        }

        public bool IsDraw()
        {
            return true;
        }

    }
}
