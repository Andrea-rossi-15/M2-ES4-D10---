using System.Globalization;
using System.Linq;
using UnityEngine;

public class esercizio2 : MonoBehaviour
{
    public int a = 0;
    public int b = 10;
    int c = 0;



    // Start is called before the first frame update
    void Start()
    {

        GeneraArray(c, a, b);
        StampaArray();
        TrovaMinimo();
        TrovaMassimo();



    }

    // Update is called once per frame
    void Update()
    {

    }
    int GeneraArray(int Dimensione, int minimo, int massimo)
    {
        int[] Array = new int[10];
        Dimensione = Random.Range(minimo, massimo);
        Array[Dimensione] = Random.Range(minimo, massimo);
        Debug.Log(Array[Dimensione]);
        return Array[Dimensione];
    }

    void StampaArray()
    {
        int[] ArrayStampato = new int[10];
        for (int i = 0; i < ArrayStampato.Length; i++)
        {
            ArrayStampato[i] = Random.Range(0, 100);
            int stampa = ArrayStampato[i];
            Debug.Log(stampa);
        }
    }

    int TrovaMinimo()
    {
        int[] ArrayMinimo = new int[9];
        ArrayMinimo[0] = Random.Range(0, 100);
        ArrayMinimo[1] = Random.Range(0, 100);
        ArrayMinimo[2] = Random.Range(0, 100);
        ArrayMinimo[3] = Random.Range(0, 100);
        ArrayMinimo[4] = Random.Range(0, 100);
        ArrayMinimo[5] = Random.Range(0, 100);
        ArrayMinimo[6] = Random.Range(0, 100);
        ArrayMinimo[7] = Random.Range(0, 100);
        ArrayMinimo[8] = Random.Range(0, 100);

        int num = ArrayMinimo.Min();
        Debug.Log(num);
        return num;


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



