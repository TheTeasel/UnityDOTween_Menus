using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ControlTiles : MonoBehaviour
{
    public GameObject MenuTitle;
    public GameObject MenuTile1;
    public GameObject MenuTile2;
    public GameObject MenuTile3;
    public GameObject MenuTile4;
    public GameObject MenuTile5;

    private RectTransform rectMenuTitle;
    private RectTransform rectMenuTile1;
    private RectTransform rectMenuTile2;
    private RectTransform rectMenuTile3;
    private RectTransform rectMenuTile4;
    private RectTransform rectMenuTile5;

    private void Awake()
    {
        rectMenuTitle = MenuTitle.GetComponent<RectTransform>();
        rectMenuTile1 = MenuTile1.GetComponent<RectTransform>();
        rectMenuTile2 = MenuTile2.GetComponent<RectTransform>();
        rectMenuTile3 = MenuTile3.GetComponent<RectTransform>();
        rectMenuTile4 = MenuTile4.GetComponent<RectTransform>();
        rectMenuTile5 = MenuTile5.GetComponent<RectTransform>();

        HideMenu();
    }

    private void Start()
    {
        ShowMenu(0.3f);
    }

    private void HideMenu()
    {
        rectMenuTitle.DOAnchorPosX(-rectMenuTitle.rect.width * 2, 0f);
        rectMenuTile1.DOAnchorPosX(rectMenuTile1.rect.width * 2, 0f);
        rectMenuTile2.DOAnchorPosX(-rectMenuTile2.rect.width * 2, 0f);
        rectMenuTile3.DOAnchorPosX(-rectMenuTile3.rect.width * 2, 0f);
        rectMenuTile4.DOAnchorPosY(-rectMenuTile4.rect.height * 2, 0f);
        rectMenuTile5.DOAnchorPosX(rectMenuTile5.rect.width * 2, 0f);
    }

    private void ShowMenu(float delay = 0f)
    {
        rectMenuTile1.DOAnchorPosX(0, 1f).SetDelay(delay);
        rectMenuTitle.DOAnchorPosX(0, 1f).SetDelay(delay);
        rectMenuTile2.DOAnchorPosX(0, 1f).SetDelay(delay);
        rectMenuTile3.DOAnchorPosX(0, 1f).SetDelay(delay);
        rectMenuTile4.DOAnchorPosY(0, 1f).SetDelay(delay);
        rectMenuTile5.DOAnchorPosX(0, 1f).SetDelay(delay);
    }

    #region Buttons click

    public void btnTile1_Click()
    {

    }

    public void btnTile2_Click()
    {

    }

    public void btnTile3_Click()
    {

    }

    public void btnTile4_Click()
    {

    }

    public void btnTile5_Click()
    {

    }
    #endregion
}
