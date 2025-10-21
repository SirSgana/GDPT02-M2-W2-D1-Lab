using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    [SerializeField] int integerNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (integerNumber % 2 == 0)
        {
            Debug.Log("Il numero " + integerNumber + " è pari.");
        }
        else
        {
            Debug.Log("Il numero " + integerNumber + " è dipari");
        }
    }
}
