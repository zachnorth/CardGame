using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Globals
{
    public static float ScreenLeft = ScreenUtils.ScreenLeft - (float)(0.1 * ScreenUtils.ScreenLeft);
    public static float ScreenRight = ScreenUtils.ScreenRight - (float)(0.1 * ScreenUtils.ScreenRight);
    public static float ScreenBottom = ScreenUtils.ScreenBottom - (float)(0.1 * ScreenUtils.ScreenBottom);
    public static float ScreenTop = ScreenUtils.ScreenTop - (float)(0.1 * ScreenUtils.ScreenTop);


    public static int number_of_players = 4;

    public static float[] four_player = { 0, ScreenBottom, ScreenLeft, 0, ScreenRight, 0, 0, ScreenTop };
    public static Tuple<string, string>[,] All_Players_Hands = new Tuple<string, string>[8, 52];

    public struct four_player_game
    {
        //Player 1
        public static float player_one_x = 0;
        public static float player_one_y = ScreenBottom;

        //Player 2
        public static float player_two_x = ScreenLeft;
        public static float player_two_y = 0;

        //Player 3
        public static float player_three_x = 0;
        public static float player_three_y = ScreenTop;

        //Player 4
        public static float player_four_x = ScreenRight;
        public static float player_four_y = 0;
    }

    public struct five_player_game
    {
        public static float player_one_x = 0;
        public static float player_one_y = ScreenBottom;
    }
}
