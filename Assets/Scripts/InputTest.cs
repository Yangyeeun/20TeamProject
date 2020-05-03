using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputTest : MonoBehaviour
{
    [SerializeField] private Text TextMoney;
    [SerializeField] private InputField InputMoney;
    // Start is called before the first frame update
    private int curMoney;
    public void Input()
    {
        curMoney += int.Parse(InputMoney.text);
        TextMoney.text=curMoney.ToString();

}

public void Output()
    {
        curMoney -= int.Parse(InputMoney.text);
        TextMoney.text = curMoney.ToString();

    }
}
