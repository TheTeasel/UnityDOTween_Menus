using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCross : MonoBehaviour
{
    #region Main menu

    public void btnUp_Click()
    {
        MainMenuCrossManager.Instance.Hide(0, 1, false);
        UpMenuCrossManager.Instance.Show();
    }

    public void btnDown_Click()
    {
        MainMenuCrossManager.Instance.Hide(0, -1, false);
        DownMenuCrossManager.Instance.Show();
    }

    public void btnRight_Click()
    {
        MainMenuCrossManager.Instance.Hide(0, 1, true);
        RightMenuCrossManager.Instance.Show();
    }

    public void btnLeft_Click()
    {
        MainMenuCrossManager.Instance.Hide(0, -1, true);
        LeftMenuCrossManager.Instance.Show();
    }

    #endregion

    #region Other menus

    public void btnMainFromUp_Click()
    {
        UpMenuCrossManager.Instance.Hide();
        MainMenuCrossManager.Instance.Show(0, false);
    }

    public void btnMainFromDown_Click()
    {
        DownMenuCrossManager.Instance.Hide();
        MainMenuCrossManager.Instance.Show(0, false);
    }

    public void btnMainFromRight_Click()
    {
        RightMenuCrossManager.Instance.Hide();
        MainMenuCrossManager.Instance.Show(0, true);
    }

    public void btnMainFromLeft_Click()
    {
        LeftMenuCrossManager.Instance.Hide();
        MainMenuCrossManager.Instance.Show(0, true);
    }

    #endregion
}
