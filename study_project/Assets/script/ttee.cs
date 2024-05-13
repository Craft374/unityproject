using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Events;
using UnityEngine.Android;
using TMPro;

public class ttee : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button BuBu;
    public GameObject makja;
    void Start()
    {
        BuBu.onClick.AddListener(OnButtonClicked);
        inputField.onEndEdit.AddListener(OnEndEdit);
        makja = GameObject.Find("makja");
        makja.SetActive(true);
    }

    private void OnEndEdit(string value)
    {
        if (!inputField.isFocused)
        {
            makja.SetActive(true);
            Debug.Log("입력 안함ㅋ");
        }
    }

    private void OnButtonClicked()
    {
        inputField.ActivateInputField();
        makja.SetActive(false);
    }
}
