using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LeftMenuSlidingManager : MonoBehaviour
{
    RectTransform rectTransform;
    static LeftMenuSlidingManager instance;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.DOAnchorPosX(-rectTransform.rect.width, 0f);
    }

    #region Get / Set
    public static LeftMenuSlidingManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<LeftMenuSlidingManager>();
            if (instance == null)
                Debug.LogError("LeftMenuUIManager not found");
            return instance;
        }
    }
    #endregion

    #region Hide / Show functions

    /// <summary>
    /// Show the left menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    public void Show(float delay = 0f)
    {
        LeftButtonSlidingManager.Instance.Hide();
        rectTransform.DOAnchorPosX(0, 0.3f).SetDelay(delay);
    }

    /// <summary>
    /// Hide the left menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    public void Hide(float delay = 0f)
    {
        rectTransform.DOAnchorPosX(-rectTransform.rect.width, 0.3f).SetDelay(delay);
        LeftButtonSlidingManager.Instance.Show();
    }

    #endregion
}
