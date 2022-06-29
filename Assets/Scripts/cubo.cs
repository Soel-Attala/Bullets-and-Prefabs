using UnityEngine;

public class cubo : MonoBehaviour
{
    public int vida = 100;

    public float hor;

    public float ver;
    public float speed = 100;
    public GameObject proyectilPrefab;

    public Transform posicionTorreta;

    



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        Shoot();
    }

    void MovimientoJugador()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(hor,0,ver) * speed * Time.deltaTime);
        
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilPrefab,posicionTorreta.position,transform.rotation);
        };
    }
}
