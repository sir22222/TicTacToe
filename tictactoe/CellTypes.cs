using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    internal enum CellTypes
    {
        X,
        O,
        vertical_wall,
        horizontal_wall,
        top_left_corner,
        bottom_left_corner,
        top_right_corner,
        bottom_right_corner,
        T_intersection_top,
        T_intersection_bottom,
        T_intersection_left,
        T_intersection_right,
        inside_intersection

    }

}
