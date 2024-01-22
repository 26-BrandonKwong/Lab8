using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
public Text displayText;

    private string currentInput = "";

    public void OnButtonClick(string value)
    {
        // Append the clicked button value to the input
        currentInput += value;

        // Update the display
        displayText.text = currentInput;
    }

    public void OnClearClick()
    {
        // Clear the input
        currentInput = "";

        // Update the display
        displayText.text = "0";
    }

    public void OnCalculateClick()
    {
        // Perform currency conversion using the currentInput value
        // You can call the currency conversion logic here

        // Display the result
        // displayText.text = result.ToString("F2");
    }
}
