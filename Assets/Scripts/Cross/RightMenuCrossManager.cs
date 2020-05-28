using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RightMenuCrossManager : MonoBehaviour
{
    RectTransform rectTransform;
    static RightMenuCrossManager instance;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.DOAnchorPosX(rectTransform.rect.width, 0f);
    }

    #region Get / Set
    public static RightMenuCrossManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<RightMenuCrossManager>();
            if (instance == null)
                Debug.LogError("RightMenuCrossManager not found");
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
        rectTransform.DOAnchorPosX(rectTransform.rect.width, 0.3f).SetDelay(delay);
    }

    #endregion
}
