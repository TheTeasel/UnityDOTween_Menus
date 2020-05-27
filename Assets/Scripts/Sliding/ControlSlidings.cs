using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSlidings : MonoBehaviour
{
    public void btnShowRightMenu_Click()
    {
        RightMenuSlidingManager.Instance.Show();
        LeftMenuSlidingManager.Instance.Hide();
    }

    public void btnShowLeftMenu_Click()
    {
        RightMenuSlidingManager.Instance.Hide();
        LeftMenuSlidingManager.Instance.Show();
    }

    public void btnRightPanel_Click()
    {
        RightMenuSlidingManager.Instance.Show();
        LeftMenuSlidingManager.Instance.Hide();
    }

    public void btnLeftPanel_Click()
    {
        RightMenuSlidingManager.Instance.Hide();
        LeftMenuSlidingManager.Instance.Show();
    }
}
