using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSequence : MonoBehaviour
{
    //Store the current menu
    public int currentMenu;

    private void Start()
    {
        currentMenu = 1;
    }

    #region Buttons click
    public void btnMainMenu_Click()
    {
        HideCurrentMenu();
        currentMenu = 1;
        MainMenuSequenceManager.Instance.Show();
    }

    public void btnMenu2_Click()
    {
        HideCurrentMenu();
        currentMenu = 2;
        Menu2SequenceManager.Instance.Show();
    }

    public void btnMenu3_Click()
    {
        HideCurrentMenu();
        currentMenu = 3;
        Menu3SequenceManager.Instance.Show();
    }

    public void btnMenu4_Click()
    {
        HideCurrentMenu();
        currentMenu = 4;
        Menu4SequenceManager.Instance.Show();
    }

    #endregion

    /// <summary>
    /// Hide the current menu
    /// </summary>
    private void HideCurrentMenu()
    {
        switch(currentMenu)
        {
            case 1:
                MainMenuSequenceManager.Instance.Hide();
                break;
            case 2:
                Menu2SequenceManager.Instance.Hide();
                break;
            case 3:
                Menu3SequenceManager.Instance.Hide();
                break;
            case 4:
                Menu4SequenceManager.Instance.Hide();
                break;
        }
    }
}
