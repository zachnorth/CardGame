using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initializes the game
/// </summary>
public class GameInitializer : MonoBehaviour
{
    /// <summary>
    /// Awake is called before Start
    /// </summary>
	void Awake()
    {
        // initialize screen utils
        //AudioManager.Play(AudioClipName.BallSpawned);
        ScreenUtils.Initialize();
        Globals.Initialize();
    }

    public void NumberOfPlayers(int i)
    {
        Globals.Number_Of_Players = i;
    }
}