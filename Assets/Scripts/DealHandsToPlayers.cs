using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealHandsToPlayers : MonoBehaviour
{
    int number_of_players = Globals.number_of_players;
    int cards_per_hand = (int)(Mathf.Floor(52 / Globals.number_of_players));

    #region All The Cards

    #region Hearts

    [SerializeField]
    GameObject prefab_AceOfHearts;

    [SerializeField]
    GameObject prefab_TwoOfHearts;

    [SerializeField]
    GameObject prefab_ThreeOfHearts;

    [SerializeField]
    GameObject prefab_FourOfHearts;

    [SerializeField]
    GameObject prefab_FiveOfHearts;

    [SerializeField]
    GameObject prefab_SixOfHearts;

    [SerializeField]
    GameObject prefab_SevenOfHearts;

    [SerializeField]
    GameObject prefab_EightOfHearts;

    [SerializeField]
    GameObject prefab_NineOfHearts;

    [SerializeField]
    GameObject prefab_TenOfHearts;

    [SerializeField]
    GameObject prefab_JackOfHearts;

    [SerializeField]
    GameObject prefab_QueenOfHearts;

    [SerializeField]
    GameObject prefab_KingOfHearts;

    #endregion

    #region Diamonds

    [SerializeField]
    GameObject prefab_AceOfDiamonds;

    [SerializeField]
    GameObject prefab_TwoOfDiamonds;

    [SerializeField]
    GameObject prefab_ThreeOfDiamonds;

    [SerializeField]
    GameObject prefab_FourOfDiamonds;

    [SerializeField]
    GameObject prefab_FiveOfDiamonds;

    [SerializeField]
    GameObject prefab_SixOfDiamonds;

    [SerializeField]
    GameObject prefab_SevenOfDiamonds;

    [SerializeField]
    GameObject prefab_EightOfDiamonds;

    [SerializeField]
    GameObject prefab_NineOfDiamonds;

    [SerializeField]
    GameObject prefab_TenOfDiamonds;

    [SerializeField]
    GameObject prefab_JackOfDiamonds;

    [SerializeField]
    GameObject prefab_QueenOfDiamonds;

    [SerializeField]
    GameObject prefab_KingOfDiamonds;

    #endregion

    #region Spades

    [SerializeField]
    GameObject prefab_AceOfSpades;

    [SerializeField]
    GameObject prefab_TwoOfSpades;

    [SerializeField]
    GameObject prefab_ThreeOfSpades;

    [SerializeField]
    GameObject prefab_FourOfSpades;

    [SerializeField]
    GameObject prefab_FiveOfSpades;

    [SerializeField]
    GameObject prefab_SixOfSpades;

    [SerializeField]
    GameObject prefab_SevenOfSpades;

    [SerializeField]
    GameObject prefab_EightOfSpades;

    [SerializeField]
    GameObject prefab_NineOfSpades;

    [SerializeField]
    GameObject prefab_TenOfSpades;

    [SerializeField]
    GameObject prefab_JackOfSpades;

    [SerializeField]
    GameObject prefab_QueenOfSpades;

    [SerializeField]
    GameObject prefab_KingOfSpades;

    #endregion

    #region Clubs

    [SerializeField]
    GameObject prefab_AceOfClubs;

    [SerializeField]
    GameObject prefab_TwoOfClubs;

    [SerializeField]
    GameObject prefab_ThreeOfClubs;

    [SerializeField]
    GameObject prefab_FourOfClubs;

    [SerializeField]
    GameObject prefab_FiveOfClubs;

    [SerializeField]
    GameObject prefab_SixOfClubs;

    [SerializeField]
    GameObject prefab_SevenOfClubs;

    [SerializeField]
    GameObject prefab_EightOfClubs;

    [SerializeField]
    GameObject prefab_NineOfClubs;

    [SerializeField]
    GameObject prefab_TenOfClubs;

    [SerializeField]
    GameObject prefab_JackOfClubs;

    [SerializeField]
    GameObject prefab_QueenOfClubs;

    [SerializeField]
    GameObject prefab_KingOfClubs;

    #endregion

    #endregion

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
        int plus_minus = 1;
        float percent_increase_per_go = 100 / cards_per_hand;

        for (int i = 0; i < number_of_players; i++)
        {
            for (int ii = 0; ii < cards_per_hand; ii++)
            {
                switch (Globals.All_Players_Hands[i, ii])
                {
                    #region Hearts
                    case "Ace of Hearts":
                        GameObject AceOfHearts = Instantiate(prefab_AceOfHearts, Globals.Locations[i] 
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), 
                            Quaternion.identity);
                        break;
                    case "Two of Hearts":
                        GameObject TwoOfHearts = Instantiate(prefab_TwoOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Three of Hearts":
                        GameObject ThreeOfHearts = Instantiate(prefab_ThreeOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Four of Hearts":
                        GameObject FourOfHearts = Instantiate(prefab_FourOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Five of Hearts":
                        GameObject FiveOfHearts = Instantiate(prefab_FiveOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Six of Hearts":
                        GameObject SixOfHearts = Instantiate(prefab_SixOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Seven of Hearts":
                        GameObject SevenOfHearts = Instantiate(prefab_SevenOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Eight of Hearts":
                        GameObject EightOfHearts = Instantiate(prefab_EightOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Nine of Hearts":
                        GameObject NineOfHearts = Instantiate(prefab_NineOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Ten of Hearts":
                        GameObject TenOfHearts = Instantiate(prefab_TenOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Jack of Hearts":
                        GameObject JackOfHearts = Instantiate(prefab_JackOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "Queen of Hearts":
                        GameObject QueenOfHearts = Instantiate(prefab_QueenOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    case "King of Hearts":
                        GameObject KingOfHearts = Instantiate(prefab_KingOfHearts, Globals.Locations[i]
                            + new Vector3((cards_per_hand / 100) * ii * plus_minus, (cards_per_hand / 100) * ii * plus_minus, 0), Quaternion.identity);
                        break;
                    #endregion

                    #region Diamonds

                    case "Ace of Diamonds":
                        GameObject AceOfDiamonds = Instantiate(prefab_AceOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Two of Diamonds":
                        GameObject TwoOfDiamonds = Instantiate(prefab_TwoOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Three of Diamonds":
                        GameObject ThreeOfDiamonds = Instantiate(prefab_ThreeOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Four of Diamonds":
                        GameObject FourOfDiamonds = Instantiate(prefab_FourOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Five of Diamonds":
                        GameObject FiveOfDiamonds = Instantiate(prefab_FiveOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Six of Diamonds":
                        GameObject SixOfDiamonds = Instantiate(prefab_SixOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Seven of Diamonds":
                        GameObject SevenOfDiamonds = Instantiate(prefab_SevenOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Eight of Diamonds":
                        GameObject EightOfDiamonds = Instantiate(prefab_EightOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Nine of Diamonds":
                        GameObject NineOfDiamonds = Instantiate(prefab_NineOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Ten of Diamonds":
                        GameObject TenOfDiamonds = Instantiate(prefab_TenOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Jack of Diamonds":
                        GameObject JackOfDiamonds = Instantiate(prefab_JackOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Queen of Diamonds":
                        GameObject QueenOfDiamonds = Instantiate(prefab_QueenOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "King of Diamonds":
                        GameObject KingOfDiamonds = Instantiate(prefab_KingOfDiamonds, Globals.Locations[i], Quaternion.identity);
                        break;

                    #endregion

                    #region Spades

                    case "Ace of Spades":
                        GameObject AceOfSpades = Instantiate(prefab_AceOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Two of Spades":
                        GameObject TwoOfSpades = Instantiate(prefab_TwoOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Three of Spades":
                        GameObject ThreeOfSpades = Instantiate(prefab_ThreeOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Four of Spades":
                        GameObject FourOfSpades = Instantiate(prefab_FourOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Five of Spades":
                        GameObject FiveOfSpades = Instantiate(prefab_FiveOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Six of Spades":
                        GameObject SixOfSpades = Instantiate(prefab_SixOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Seven of Spades":
                        GameObject SevenOfSpades = Instantiate(prefab_SevenOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Eight of Spades":
                        GameObject EightOfSpades = Instantiate(prefab_EightOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Nine of Spades":
                        GameObject NineOfSpades = Instantiate(prefab_NineOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Ten of Spades":
                        GameObject TenOfSpades = Instantiate(prefab_TenOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Jack of Spades":
                        GameObject JackOfSpades = Instantiate(prefab_JackOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Queen of Spades":
                        GameObject QueenOfSpades = Instantiate(prefab_QueenOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "King of Spades":
                        GameObject KingOfSpades = Instantiate(prefab_KingOfSpades, Globals.Locations[i], Quaternion.identity);
                        break;

                    #endregion

                    #region Clubs

                    case "Ace of Clubs":
                        GameObject AceOfClubs = Instantiate(prefab_AceOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Two of Clubs":
                        GameObject TwoOfClubs = Instantiate(prefab_TwoOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Three of Clubs":
                        GameObject ThreeOfClubs = Instantiate(prefab_ThreeOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Four of Clubs":
                        GameObject FourOfClubs = Instantiate(prefab_FourOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Five of Clubs":
                        GameObject FiveOfClubs = Instantiate(prefab_FiveOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Six of Clubs":
                        GameObject SixOfClubs = Instantiate(prefab_SixOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Seven of Clubs":
                        GameObject SevenOfClubs = Instantiate(prefab_SevenOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Eight of Clubs":
                        GameObject EightOfClubs = Instantiate(prefab_EightOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Nine of Clubs":
                        GameObject NineOfClubs = Instantiate(prefab_NineOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Ten of Clubs":
                        GameObject TenOfClubs = Instantiate(prefab_TenOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Jack of Clubs":
                        GameObject JackOfClubs = Instantiate(prefab_JackOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "Queen of Clubs":
                        GameObject QueenOfClubs = Instantiate(prefab_QueenOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;
                    case "King of Clubs":
                        GameObject KingOfClubs = Instantiate(prefab_KingOfClubs, Globals.Locations[i], Quaternion.identity);
                        break;

                    #endregion


                    default:
                        Debug.Log("Could not instantiate card at " + i + ", " + ii);
                        Debug.Log("Card: " + Globals.All_Players_Hands[i, ii]);
                        break;
                }

                plus_minus = plus_minus * -1;
            }
        }
    }
}
