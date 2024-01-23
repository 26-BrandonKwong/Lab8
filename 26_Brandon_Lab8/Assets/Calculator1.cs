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
public Toggle Malaysian;
public Toggle Euro;
public Toggle korean;
public Toggle taiwan;
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
        if (Malaysian.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 3.08f;
            Convertedvalue.text = value.ToString() + " RM";
        }
        if (Euro.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 0.63f;
            Convertedvalue.text = value.ToString() + " EUR";
        }
        if (korean.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 881.54f;
            Convertedvalue.text = value.ToString() + " KRW";
        }
        if (taiwan.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 20.73f;
            Convertedvalue.text = value.ToString() + " TWD";
        }
    }
}





