using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Events;
using UnityEngine.Android;
using TMPro;


public class onoff : MonoBehaviour
{
    public Button btn;
    public TMP_InputField inputField;
    public string p_name;
    public string memo;

    public void Start()
    {
        p_name = "";
        memo = "";

        inputField = FindTargetInputField(transform.parent);
        btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(OnButtonClicked);
        }
        if (inputField != null)
        {
            inputField.onEndEdit.AddListener(OnEndEdit);
        }
        Debug.Log("실행중");
    }

    private TMP_InputField FindTargetInputField(Transform parent)
    {
        foreach (Transform child in parent)
        {
            if (child.name == "ININ")
            {
                return child.GetComponent<TMP_InputField>();
            }
        }
        return null;
    }

    public void OnEndEdit(string value)
    {
        if (!inputField.isFocused)
        {
            Debug.Log("입력 안함ㅋ");
            p_name = transform.parent.name.ToString();
            memo = value.ToString();
            Debug.Log(p_name + " " + memo);
        }
    }

    public void OnButtonClicked()
    {
        Debug.Log("입력중ㅋ");
        inputField.ActivateInputField();
    }
}
