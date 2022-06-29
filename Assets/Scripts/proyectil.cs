using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{

    public float speed = 3;
    public int damage = 15;
    public Vector3 direccion = new Vector3 (0,0,0.1f);

    

   
    void Update()
    {
        transform.position += direccion * speed;
    }

  

    


}
