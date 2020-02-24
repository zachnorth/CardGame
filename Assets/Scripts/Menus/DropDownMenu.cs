using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownMenu : MonoBehaviour
{
    List<string> players = new List<string>() { "Please Select", "1", "2", "3", "4", "5", "6", "7", "8" };

    public Dropdown dropdown;
    public Text selectedIndex;

    public void Dropdown_Index_Changed(int index)
    {
        selectedIndex.text = players[index];
        if(index == 1)
        {
            Globals.number_of_players = 1;
        }
        else if(index == 2)
        {
            Globals.number_of_players = 2;
        }
        else if(index == 3)
        {
            Globals.number_of_players = 3;
        }
        else if(index == 4)
        {
            Globals.number_of_players = 4;
        }
        else if(index ==5)
        {
            Globals.number_of_players = 5;
        }
        else if(index == 6)
        {
            Globals.number_of_players = 6;
        }
        else if (index == 7)
        {
            Globals.number_of_players = 7;
        }
        else if (index == 8)
        {
            Globals.number_of_players = 8;
        }
        else
        {
            Debug.Log("Must select number of players");
        }
        Debug.Log("Number of Players:  " + Globals.number_of_players);
    }

    void Start()
    {
        PopulateList();
    }


    void PopulateList()
    {
        dropdown.AddOptions(players);
    }



}
