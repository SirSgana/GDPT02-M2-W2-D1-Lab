using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    [SerializeField] int startingNumber = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log (startingNumber);
        Debug.Log (--startingNumber);
        Debug.Log(--startingNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
