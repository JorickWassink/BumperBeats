using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MathGame : MonoBehaviour
{
    [SerializeField] TMP_Text somText;
    [SerializeField] TMP_Text aText;
    [SerializeField] TMP_Text bText;
    [SerializeField] TMP_Text cText;
    [SerializeField] TMP_Text dText;
    private int[] firstNumbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50};
    private int[] secondNumbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50};
    private char[] operators = { '+', '-', 'x' };
    public int firstNumber;
    int secondNumber;
    char op;
    void Start()
    {
        firstNumber = firstNumbers[UnityEngine.Random.Range(0, firstNumbers.Length)];
        secondNumber = secondNumbers[UnityEngine.Random.Range(0, secondNumbers.Length)];
        op = operators[UnityEngine.Random.Range(0,operators.Length)];
        somText.text = Convert.ToString($"{firstNumber}   {op}   {secondNumber}");
        int answer = GetAnswer(firstNumber,secondNumber,op);
        aText.text = Convert.ToString(answer - UnityEngine.Random.Range(4, 15));
        bText.text = Convert.ToString(answer + UnityEngine.Random.Range(4, 15));
        cText.text = Convert.ToString(answer - UnityEngine.Random.Range(4, 15));
        dText.text = Convert.ToString(answer + UnityEngine.Random.Range(4, 15));
        int whichOne = UnityEngine.Random.Range(1, 5);
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
        else if (pop == '*')
        {
            answer = firstNumberP * secondNumberP;
        }
        return answer;
    }
}
