﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTab : MonoBehaviour
{
    //Store the current displayed menu
    private int currentMenu = 1;

    public void tabMenu1_Click()
    {
        //Check if user try to display current menu again
        if(currentMenu != 1)
        {
            HideCurrentMenu();
            MenuTab1Manager.Instance.Show();
            currentMenu = 1;
        }
    }

    public void tabMenu2_Click()
    {
        //Check if user try to display current menu again
        if (currentMenu != 2)
        {
            HideCurrentMenu();
            MenuTab2Manager.Instance.Show();
            currentMenu = 2;
        }
    }

    public void tabMenu3_Click()
    {
        //Check if user try to display current menu again
        if (currentMenu != 3)
        {
            HideCurrentMenu();
            MenuTab3Manager.Instance.Show();
            currentMenu = 3;
        }
    }

    /// <summary>
    /// Hide the current menu
    /// </summary>
    private void HideCurrentMenu()
    {
        switch(currentMenu)
        {
            case 1:
                MenuTab1Manager.Instance.Hide();
                break;
            case 2:
                MenuTab2Manager.Instance.Hide();
                break;
            case 3:
                MenuTab3Manager.Instance.Hide();
                break;
        }
    }
}
