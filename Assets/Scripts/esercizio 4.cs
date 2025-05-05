using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class esercizio4 : MonoBehaviour
{
    public int dim = 15;
    // Start is called before the first frame update
    void Start()
    {
        int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        CambiaDimensioneArray(Array, dim);


    }



    void CambiaDimensioneArray(int[] ArrayDaModificare, int dim)
    {
        if (dim < ArrayDaModificare.Length)
        {
            int[] NuovoArrayMinore = new int[dim];


            for (int i = 0; i < dim; i++)
            {
                NuovoArrayMinore[i] = ArrayDaModificare[i];
            }
            Debug.Log("Array Minore " + string.Join(",", NuovoArrayMinore));

        }




        if (dim > ArrayDaModificare.Length)

        {
            int[] NuovoArrayMaggiore = new int[dim];


            for (int i = 0; i < ArrayDaModificare.Length; i++)
            {
                NuovoArrayMaggiore[i] = ArrayDaModificare[i];
            }
            Debug.Log("Array Maggiore " + string.Join(",", NuovoArrayMaggiore));
        }






        if (dim == ArrayDaModificare.Length)
        {
            Debug.Log(" Array Uguale " + string.Join(",", ArrayDaModificare));
        }

    }



}
