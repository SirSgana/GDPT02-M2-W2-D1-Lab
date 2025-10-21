using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField]int StartingNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StartingNumber);
        Debug.Log(StartingNumber + 1);
        Debug.Log(StartingNumber + 2);
    }
}
