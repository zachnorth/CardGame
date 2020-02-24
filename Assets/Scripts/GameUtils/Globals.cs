using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    public static float ScreenLeft = ScreenUtils.ScreenLeft;
    public static float ScreenRight = ScreenUtils.ScreenRight;
    public static float ScreenBottom = ScreenUtils.ScreenBottom;
    public static float ScreenTop = ScreenUtils.ScreenTop;


    public static int number_of_players = 4;

    public struct four_player_game
    {
        //Player 1
        static float player_one_x = 0;
        static float player_one_y = ScreenBottom;

        //Player 2
        static float player_two_x = ScreenLeft;
        static float player_two_y = 0;

        //Player 3
        static float player_three_x = 0;
        static float player_three_y = ScreenTop;

        //Player 4
        static float player_four_x = ScreenRight;
        static float player_four_y = 0;
    }
}
