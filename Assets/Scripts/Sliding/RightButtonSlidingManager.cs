using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RightButtonSlidingManager : MonoBehaviour
{
    RectTransform rectTransform;
    static RightButtonSlidingManager instance;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    #region Get / Set
    public static RightButtonSlidingManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<RightButtonSlidingManager>();
            if (instance == null)
                Debug.LogError("RightButtonSlidingManager not found");
            return instance;
        }
    }
    #endregion

    #region Hide / Show functions

    /// <summary>
    /// Show the right menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    public void Show(float delay = 0f)
    {
        rectTransform.DOAnchorPosX(0, 0.3f).SetDelay(delay);
    }

    /// <summary>
    /// Hide the right menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    public void Hide(float delay = 0f)
    {
        rectTransform.DOAnchorPosX(rectTransform.rect.width, 0.3f).SetDelay(delay);
    }

    #endregion
}
