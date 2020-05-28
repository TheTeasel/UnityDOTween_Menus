using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuTab3Manager : MonoBehaviour
{
    RectTransform rectTransform;
    static MenuTab3Manager instance;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.DOAnchorPosX(rectTransform.rect.width * 2, 0f);
    }

    #region Get / Set
    public static MenuTab3Manager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<MenuTab3Manager>();
            if (instance == null)
                Debug.LogError("MenuTab3Manager not found");
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
