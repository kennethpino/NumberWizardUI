using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class InputValidator : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button higherButton;
    public Button lowerButton;

    public void ChopOffExcess()
    {
        try
        {
            if (inputField.text.Length > 3)
            {
                inputField.text = inputField.text.Remove(3);
            }

            if (int.Parse(inputField.text) < 1)
            {
                inputField.text = " ";
            }

            if (inputField.text.Length > 0)
            {
                higherButton.interactable = true;
                lowerButton.interactable = true;
            }
        }
        catch (FormatException e)
        {
            Debug.Log($"Incorrect values.\n" + e.Message);
            inputField.text = " ";
        }
    }
}
