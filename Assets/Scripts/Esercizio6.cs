using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    [SerializeField] int a = 5;
    [SerializeField] int b = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (a < b)
        {
            Debug.Log(b);
        }
        else
        {
            Debug.Log(a);
        }
    }
}
