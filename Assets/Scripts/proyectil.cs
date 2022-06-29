using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{

    public float speed = 3;

   
    void Update()
    {
        transform.Translate(new Vector3(0,0,0.1f) * speed);
    }

    


}
