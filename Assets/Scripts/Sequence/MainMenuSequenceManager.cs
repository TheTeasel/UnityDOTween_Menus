using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainMenuSequenceManager : MonoBehaviour
{
    RectTransform rectTransform;
    static MainMenuSequenceManager instance;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    #region Get / Set
    public static MainMenuSequenceManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<MainMenuSequenceManager>();
            if (instance == null)
                Debug.LogError("MainMenuSequenceManager not found");
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
        rectTransform.DOAnchorPosX(-rectTransform.rect.width, 0.3f).SetDelay(delay);
    }

    #endregion
}
