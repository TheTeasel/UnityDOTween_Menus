using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LeftButtonSlidingManager : MonoBehaviour
{
    RectTransform rectTransform;
    static LeftButtonSlidingManager instance;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    #region Get / Set
    public static LeftButtonSlidingManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<LeftButtonSlidingManager>();
            if (instance == null)
                Debug.LogError("LeftButtonSlidingManager not found");
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
        rectTransform.DOAnchorPosX(-rectTransform.rect.width, 0.3f).SetDelay(delay);
    }

    #endregion
}
