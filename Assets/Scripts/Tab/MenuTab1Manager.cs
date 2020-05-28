using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuTab1Manager : MonoBehaviour
{
    RectTransform rectTransform;
    static MenuTab1Manager instance;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    #region Get / Set
    public static MenuTab1Manager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<MenuTab1Manager>();
            if (instance == null)
                Debug.LogError("MenuTab1Manager not found");
            return instance;
        }
    }
    #endregion

    #region Hide / Show functions

    /// <summary>
    /// Show the menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    public void Show(float delay = 0f)
    {
        rectTransform.DOAnchorPosX(0, 0.3f).SetDelay(delay);
    }

    /// <summary>
    /// Hide the menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    public void Hide(float delay = 0f)
    {
        rectTransform.DOAnchorPosX(rectTransform.rect.width * 2, 0.3f).SetDelay(delay);
    }

    #endregion
}
