using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System;

public class CloseButton : MonoBehaviour
{
    Button closeButton;
    void Start()
    {
        closeButton = GetComponent<Button>();
        closeButton.onClick.AddListener(CloseMenu);
    }

    private void CloseMenu()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
