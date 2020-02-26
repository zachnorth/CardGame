using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Globals
{
    static float screenLeft;
    static float screenRight;
    static float screenBottom;
    static float screenTop;

    



    public static string[,] All_Players_Hands = new string[8, 52];

    public static int number_of_players = 4;

    static Vector3[] locations = new Vector3[number_of_players];

    //public static float[] four_player = { 0, ScreenBottom, ScreenLeft, 0, ScreenRight, 0, 0, ScreenTop };


    #region old
    /*
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
    */
    #endregion

    public static float ScreenLeft
    {
        get { return screenLeft; }
    }

    public static float ScreenRight
    {
        get { return screenRight; }
    }

    public static float ScreenBottom
    {
        get { return screenBottom; }
    }

    public static float ScreenTop
    {
        get { return screenTop; }
    }

    public static Vector3[] Locations
    {
        get { return locations; }
    }

    public static void Initialize()
    {
        screenLeft = (ScreenUtils.ScreenLeft - (float)(0.1 * ScreenUtils.ScreenLeft));
        screenRight = (ScreenUtils.ScreenRight - (float)(0.1 * ScreenUtils.ScreenRight));
        screenBottom = (ScreenUtils.ScreenBottom - (float)(0.1 * ScreenUtils.ScreenBottom));
        screenTop = (ScreenUtils.ScreenTop - (float)(0.1 * ScreenUtils.ScreenTop));
        switch (number_of_players)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                locations[0] = new Vector3(0, ScreenBottom, 0);
                locations[1] = new Vector3(ScreenLeft, 0, 0);
                locations[2] = new Vector3(ScreenRight, 0, 0);
                locations[3] = new Vector3(0, ScreenTop, 0);
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            default:
                break;
        }
    }
        
}
