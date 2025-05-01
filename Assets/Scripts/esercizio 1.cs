using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;
using UnityEngine;

public class esercizio1 : MonoBehaviour
{
    public int N = 20;
    public int X = 8;
    public int Y = 24;
    // Start is called before the first frame update
    void Start()
    {

        if (IsEven(N))
        {
            Debug.Log("il numero " + N + " è pari");
        }

        if (IsMultipleOf(Y, X))
        {
            Debug.Log("il numero " + Y + " è multiplo di " + X);
        }

    }







    bool IsEven(int number)
    {
        return number % 2 == 0;
    }


    bool IsMultipleOf(int X, int Y)

    {
        return X % Y == 0;
    }







    // Update is called once per frame
    void Update()
    {

    }


}
