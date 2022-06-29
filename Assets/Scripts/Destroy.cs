using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   public float tiempoADestruir = 0.5f;
    void Start()
    {
        Destroy(gameObject,tiempoADestruir);
    }

    
}
