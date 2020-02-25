using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealHandsToPlayers : MonoBehaviour
{
    int number_of_players = Globals.number_of_players;
    int cards_per_hand = (int)(Mathf.Floor(52 / Globals.number_of_players));

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Deal()
    {
        for(int i = 0; i < number_of_players; i++)
        {
            for(int ii = 0; ii < cards_per_hand; ii++)
            {
                switch (Globals.All_Players_Hands)
                {
                    case ("Ace", "Hearts"):

                }
            }
        }
}
