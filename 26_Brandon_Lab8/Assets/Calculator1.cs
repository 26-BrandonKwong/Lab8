using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator1 : MonoBehaviour
{
public InputField txtAmount;
float SGDAmount;
public Toggle USD;
public Toggle JPY;
float value;
public Text Convertedvalue;

public void conversion()
{
SGDAmount = float.Parse(txtAmount.text);

if (USD.GetComponent<Toggle>().isOn == true)
{
       value = SGDAmount * 0.74f;
Convertedvalue.text = value.ToString() + " USD";


}


if(JPY.GetComponent<Toggle>().isOn == true)
{
      value = SGDAmount * 82.78f;
Convertedvalue.text = value.ToString() + " JPY";
}

if((USD.GetComponent<Toggle>().isOn == true) && (JPY.GetComponent<Toggle>().isOn == true))
{
Convertedvalue.text = "Enter a valid option";
}


}
 public void clear()
    {
        txtAmount.text = "";
        Convertedvalue.text = "";
JPY.GetComponent<Toggle>().isOn = false;
USD.GetComponent<Toggle>().isOn = false;
    }
}





