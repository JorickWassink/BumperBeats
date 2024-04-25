using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MathGame : MonoBehaviour
{
    public TMP_Text somText;
    [SerializeField] TMP_Text aText;
    [SerializeField] TMP_Text bText;
    [SerializeField] TMP_Text cText;
    [SerializeField] TMP_Text dText;
    private char[] operators = { '+', '-', 'x' };
    public int firstNumber;
    int secondNumber;
    char op;
    public int whichOne;
    void Start()
    {
        firstNumber = UnityEngine.Random.Range(0,50);
        secondNumber = UnityEngine.Random.Range(0, 50);
        op = operators[UnityEngine.Random.Range(0,operators.Length)];
        somText.text = Convert.ToString($"{firstNumber}   {op}   {secondNumber}");
        int answer = GetAnswer(firstNumber,secondNumber,op);
        aText.text = Convert.ToString(answer - UnityEngine.Random.Range(4, 15));
        bText.text = Convert.ToString(answer + UnityEngine.Random.Range(4, 15));
        cText.text = Convert.ToString(answer - UnityEngine.Random.Range(4, 15));
        dText.text = Convert.ToString(answer + UnityEngine.Random.Range(4, 15));
        print(answer);
        whichOne = UnityEngine.Random.Range(1, 5);
        if (whichOne == 1)
        {
            aText.text = Convert.ToString(answer);
        }
        else if (whichOne == 2)
        {
            bText.text = Convert.ToString(answer);
        }
        else if (whichOne == 3)
        {
            cText.text = Convert.ToString(answer);
        }
        else if (whichOne == 4)
        {
            dText.text = Convert.ToString(answer);
        }
    }




    private int GetAnswer(int firstNumberP, int secondNumberP , char pop)
    {
        int answer = 0;
        if (pop == '+')
        {
            answer = firstNumberP + secondNumberP;
        }
        else if (pop == '-')
        {
            answer = firstNumberP - secondNumberP;
        }
        else if (pop == 'x')
        {
            answer = firstNumberP * secondNumberP;
        }
        return answer;
    }
}
