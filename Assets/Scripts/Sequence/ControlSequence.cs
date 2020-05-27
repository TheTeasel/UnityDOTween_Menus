using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSequence : MonoBehaviour
{
    public int currentMenu;

    private void Start()
    {
        currentMenu = 1;
    }

    public void btnMainMenu_Click()
    {
        HidePreviousMenu();
        currentMenu = 1;
        MainMenuSequenceManager.Instance.Show();
    }

    public void btnMenu2_Click()
    {
        HidePreviousMenu();
        currentMenu = 2;
        Menu2SequenceManager.Instance.Show();
    }

    public void btnMenu3_Click()
    {
        HidePreviousMenu();
        currentMenu = 3;
        Menu3SequenceManager.Instance.Show();
    }

    public void btnMenu4_Click()
    {
        HidePreviousMenu();
        currentMenu = 4;
        Menu4SequenceManager.Instance.Show();
    }

    private void HidePreviousMenu()
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
