using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeckStart : MonoBehaviour
{
    [SerializeField]
    GameObject prefab_Ace_Of_Clubs;

    //Variables that help create the deck
    Tuple<string, string>[] Deck = new Tuple<string, string>[52];
    string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
    string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
    int suit_thelper = -1;


    //Variables that help deal hands to players
    Tuple<string, string>[] kitty = new Tuple<string, string>[52];
    int number_of_cards_in_kitty = 0;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Where I can put a check to see if the deck has been dealt or to see if the deck image needs updating
    }

    public void StartGame()
    {
        myFunction();
        Deck = Shuffle(Deck);

        Tuple<string, string>[,] all_hands = Hands(Globals.number_of_players, Deck);


        #region Players_Hands + Kitty
        /*
        for(int i = (52 - number_of_cards_in_kitty); i < 52; i++)
        {
            Debug.Log(kitty[i]);
        }
        */

        //Remove "//" to see each players hand
        /*
        for (int i = 0; i < 4; i++)
        {
            for(int ii = 0; ii < 13; ii++)
            {
                Debug.Log("Player " + (i + 1) + " Card " + (ii + 1) + ":  " + all_hands[i, ii]);
            }
        }
        */
        #endregion

        switch (Globals.number_of_players)
        {
            case 1:
                Debug.Log("1 Player Game");
                break;
            case 2:
                Debug.Log("2 Player Game");
                break;
            case 3:
                Debug.Log("3 Player Game");
                break;
            case 4:
                Debug.Log("4 Player Game");


                break;
            case 5:
                Debug.Log("5 Player Game");
                break;
            case 6:
                Debug.Log("6 Player Game");
                break;
            case 7:
                Debug.Log("7 Player Game");
                break;
            case 8:
                Debug.Log("8 Player Game");
                break;
            default:
                Debug.Log("How many players ya idiot??");
                break;
        }

        GameObject NewCard = Instantiate(prefab_Ace_Of_Clubs, Vector3.zero, Quaternion.identity);
    }

    public Tuple<string, string>[] myFunction()
    {
        for (int i = 0; i < 52; i++)
        {
            if (i % 13 == 0)
            {
                suit_thelper++;
            }
            Deck[i] = Tuple.Create(values[(i % 13)], suits[suit_thelper]);
            //Debug.Log(Deck[i]);
        }
        return Deck;
    }


    //Method that deals hands to player
    public Tuple<string, string>[,] Hands(int number_of_players, Tuple<string, string>[] Deck)
    {
        int deal_to_player = 0;
        Tuple<string, string>[,] current_hands = new Tuple<string, string>[number_of_players, (int)Math.Floor((double)(52/number_of_players))];
        int number_of_cards_per_hand = (int)Math.Floor((double)(52 / number_of_players));
        int number_of_cards = 52 - (52 - (number_of_cards_per_hand * number_of_players));

        //Un-comment this line to print number of cards in each players hand
        //Debug.Log("# Cards: " + number_of_cards);
        


        for (int i = 0; i < number_of_cards; i++)
        {
            deal_to_player = deal_to_player % number_of_players;
            current_hands[deal_to_player, i % number_of_cards_per_hand] = Deck[i];
            deal_to_player++;
        }


        for(int i = number_of_cards; i < 52; i++)
        {
            kitty[i] = Deck[i];
            number_of_cards_in_kitty++;
        }


        return current_hands;
    }



    //Shuffles the deck
    public Tuple<string, string>[] Shuffle(Tuple<string, string>[] Deck)
    {
        System.Random rnd = new System.Random();
        for(int i = 0; i < 52; i++)
        {
            int ii = rnd.Next(0, 51);
            if (i != ii)
            {
                Tuple<string, string> temp = Deck[i];
                Deck[i] = Deck[ii];
                Deck[ii] = temp;
            }

        }
        return Deck;
    }


    public void ShowHands()
    {
        //Starting point: This will deal hands to each player and instantiate all the cards on the screen
    }
}
