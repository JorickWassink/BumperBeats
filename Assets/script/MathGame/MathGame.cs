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
    private char[] operators = { '+', '-', 'x' }; // maakt een array van chars aan en geeft die 3 waardes
    public int firstNumber;
    int secondNumber;
    char op;
    public int whichOne;
    void Start()
    {
        firstNumber = UnityEngine.Random.Range(0,50); // geeft de waarde van een random getal tussen de 0 en 49
        secondNumber = UnityEngine.Random.Range(0, 50);
        op = operators[UnityEngine.Random.Range(0,operators.Length)]; // geeft de waarde van een random getal tussen 0 en de lengte van een array
        somText.text = Convert.ToString($"{firstNumber}   {op}   {secondNumber}");
        int answer = GetAnswer(firstNumber,secondNumber,op); // runt een method en geeft 3 parameters mee
        aText.text = Convert.ToString(answer - UnityEngine.Random.Range(4, 15)); // veranderdt de text in het text object
        bText.text = Convert.ToString(answer + UnityEngine.Random.Range(4, 15));
        cText.text = Convert.ToString(answer - UnityEngine.Random.Range(4, 15));
        dText.text = Convert.ToString(answer + UnityEngine.Random.Range(4, 15));
        print(answer); // print de waarde van een int in de console
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




    private int GetAnswer(int firstNumberP, int secondNumberP , char pop) // maakt een nieuwe method aan die 3 parameters vraagt
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
