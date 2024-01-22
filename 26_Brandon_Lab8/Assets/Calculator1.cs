using System.Collections;
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
float valueamount;


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
      value = SGDAmount * 110.5f;
Convertedvalue.text = value.ToString() + " JPY";
}

}
}





