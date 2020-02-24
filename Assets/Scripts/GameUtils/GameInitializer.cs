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
    }
}