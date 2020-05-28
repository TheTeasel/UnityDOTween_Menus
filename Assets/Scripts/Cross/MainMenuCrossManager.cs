using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainMenuCrossManager : MonoBehaviour
{
    RectTransform rectTransform;
    static MainMenuCrossManager instance;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    #region Get / Set
    public static MainMenuCrossManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<MainMenuCrossManager>();
            if (instance == null)
                Debug.LogError("MainMenuCrossManager not found");
            return instance;
        }
    }
    #endregion

    #region Hide / Show functions

    /// <summary>
    /// Show the menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    /// <param name="horizontal">True for horizontal movement</param>
    public void Show(float delay = 0f, bool horizontal = false)
    {
        //Horizontal movement
        if (horizontal)
        {
            rectTransform.DOAnchorPosX(0, 0.3f).SetDelay(delay);
        }
        //Vertical movement
        else if (!horizontal)
        {
            rectTransform.DOAnchorPosY(0, 0.3f).SetDelay(delay);
        }
    }

    /// <summary>
    /// Hide the menu
    /// </summary>
    /// <param name="delay">Delay for the start of the tweening</param>
    /// <param name="factor">1 for moving to positive values or -1 to move into negative values</param>
    /// <param name="horizontal">True for horizontal movement</param>
    public void Hide(float delay = 0f, int factor = 1, bool horizontal = false)
    {
        //If a wrong factor is sent in parameter
        if (factor != 1 && factor != -1)
        {
            Debug.LogError("Factor parameter should be either 1 or -1");
            return;
        }
            
        //Horizontal movement
        if(horizontal)
        {
            rectTransform.DOAnchorPosX(rectTransform.rect.width * factor, 0.3f).SetDelay(delay);
        }
        //Vertical movement
        else if(!horizontal)
        {
            rectTransform.DOAnchorPosY(rectTransform.rect.height * factor, 0.3f).SetDelay(delay);
        }
    }

    #endregion
}
