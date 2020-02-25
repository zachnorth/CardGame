using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeckStart : MonoBehaviour
{
    #region Variables
    [SerializeField]
    GameObject prefab_Ace_Of_Clubs;

    [SerializeField]
    GameObject prefabPlayer;

    //Variables that help create the deck
    Tuple<string, string>[] Deck = new Tuple<string, string>[52];
    string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
    string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

    //all Cards
    /*string[] Deck = { "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of Hearts",
        "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts",
    "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds",
        "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds",
    "Ace Of Spades", "Two Of Spades", "Three Of Spades", "Four Of Spades", "Five Of Spades", "Six Of Spades", "Seven Of Spades", "Eight Of Spades",
        "Nine Of Spades", "Ten Of Spades", "Jack Of Spades", "Queen Of Spades", "King Of Spades",
    "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs",
        "Ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs"};
        */


    int suit_thelper = 0;


    //Variables that help deal hands to players
    Tuple<string, string>[] kitty = new Tuple<string, string>[52];
    int number_of_cards_in_kitty = 0;

    //GameObject[] Players = new GameObject[Globals.number_of_players];
    int counter = 0;

    #endregion

    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Where I can put a check to see if the deck has been dealt or to see if the deck image needs updating
    }
    #endregion

    public void StartGame()
    {
        MakeDeck();
        Deck = Shuffle(Deck);

        //Tuple<string, string>[,] all_hands = Hands(Globals.number_of_players, Deck);
        Globals.All_Players_Hands = Hands(Globals.number_of_players, Deck);


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

                for (int i = 0; i < Globals.number_of_players; i++)
                {
                    MakePlayer(Globals.four_player[counter], Globals.four_player[counter + 1]);
                    counter += 2;
                }
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

    #region Methods
    #region MakeDeck
    public Tuple<string, string>[] MakeDeck()
    {
        for (int i = 0; i < 52; i++)
        {
            if (i % 13 == 0 && i != 0)
            {
                suit_thelper++;
            }
            Deck[i] = Tuple.Create(values[(i % 13)], suits[suit_thelper]);
            //Debug.Log(Deck[i]);
        }
        return Deck;
    }
    #endregion

    #region Player Hands
    //Method that deals hands to player
    public Tuple<string, string>[,] Hands(int number_of_players, Tuple<string, string>[] Deck)
    {
        //Which player is being dealt to
        int deal_to_player = 0;
        int player_card_number = 0;

        Tuple<string, string>[,] current_hands = new Tuple<string, string>[number_of_players, (int)Math.Floor((double)(52/number_of_players))];

        int number_of_cards_per_hand = (int)Math.Floor((double)(52 / number_of_players));
        int number_of_cards = 52 - (52 - (number_of_cards_per_hand * number_of_players));

        //Un-comment this line to print number of cards in each players hand
        //Debug.Log("# Cards: " + number_of_cards);
        


        for (int i = 0; i < number_of_cards; i++)
        {
            deal_to_player = deal_to_player % number_of_players;
            current_hands[deal_to_player, player_card_number] = Deck[i];
            deal_to_player++;

            if(i % number_of_players == 0 && i != 0)
            {
                player_card_number++;
            }
        }


        for(int i = number_of_cards; i < 52; i++)
        {
            kitty[i] = Deck[i];
            number_of_cards_in_kitty++;
        }


        return current_hands;
    }
    #endregion


    #region Shuffle
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
    #endregion

    #region Instantiate Players
    public void MakePlayer(float x, float y)
    {
        GameObject temp = Instantiate(prefabPlayer, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
        
        
    }
    #endregion





    #endregion
}
