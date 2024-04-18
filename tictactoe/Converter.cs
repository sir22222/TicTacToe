using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    static internal class Converter
    {
        public static CellTypes CharToCellTypes(char c)
        {
            return c switch
            {
                'X' => CellTypes.X,
                'O' => CellTypes.O,
                _ => throw new ArgumentException(),
            };
        }
    }
}
