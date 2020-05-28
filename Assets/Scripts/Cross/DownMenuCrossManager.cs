using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DownMenuCrossManager : MonoBehaviour
{
    RectTransform rectTransform;
    static DownMenuCrossManager instance;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.DOAnchorPosY(-rectTransform.rect.height, 0f);
    }

    #region Get / Set
    public static DownMenuCrossManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<DownMenuCrossManager>();
            if (instance == null)
                Debug.LogError("DownMenuCrossManager not found");
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
        rectTransform.DOAnchorPosY(0, 0.3f).SetDelay(delay);
    }

    /// <summary>
    /// Hide the menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    public void Hide(float delay = 0f)
    {
        rectTransform.DOAnchorPosY(-rectTransform.rect.height, 0.3f).SetDelay(delay);
    }

    #endregion
}
