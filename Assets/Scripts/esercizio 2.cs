using System.Globalization;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class esercizio2 : MonoBehaviour
{
    public int a = 0;
    public int b = 10;
    int c = 10;


    int numeroMaggiore = 0;
    int[] arr;
    // Start is called before the first frame update
    void Start()
    {

        //GeneraArray(c, a, b);
        //StampaArray();
        TrovaMinimo();
        // TrovaMassimo();



    }

    // Update is called once per frame
    void Update()
    {

    }
    void GeneraArray(int Dimensione, int minimo, int massimo)
    {
        int[] Array = new int[Dimensione];

        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = Random.Range(minimo, massimo);

        }
        Debug.Log(string.Join(",", Array));

    }

    void StampaArray()
    {
        int[] ArrayStampato = new int[10];
        for (int i = 0; i < ArrayStampato.Length; i++)
        {
            ArrayStampato[i] = Random.Range(0, 100);
            int stampa = ArrayStampato[i];

        }
        Debug.Log(string.Join(",", ArrayStampato));
    }

    void TrovaMinimo()
    {
        int max = arr[0];
        int max2 = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            int number = arr[i];

            if (number > max)
            {
                max = number;
            }
            else if (number > max2 && number <= max)
            {
                max2 = number;
            }
        }




    }

    int TrovaMassimo()
    {
        int[] ArrayMassimo = new int[9];

        ArrayMassimo[0] = Random.Range(0, 100);
        ArrayMassimo[1] = Random.Range(0, 100);
        ArrayMassimo[2] = Random.Range(0, 100);
        ArrayMassimo[3] = Random.Range(0, 100);
        ArrayMassimo[4] = Random.Range(0, 100);
        ArrayMassimo[5] = Random.Range(0, 100);
        ArrayMassimo[6] = Random.Range(0, 100);
        ArrayMassimo[7] = Random.Range(0, 100);
        ArrayMassimo[8] = Random.Range(0, 100);

        int num = ArrayMassimo.Max();
        Debug.Log(num);
        return num;


    }









}



