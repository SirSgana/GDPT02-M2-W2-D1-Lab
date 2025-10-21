using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    int a = 2;
    int b = 3;
    int c = 4;
    int d = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Somma" + (a + b + c + d));
        Debug.Log ("Moltiplicazione" + (a*b*c*d));
        Debug.Log ("Media" + ((a+b+c+d)/4));
        
    }
}
