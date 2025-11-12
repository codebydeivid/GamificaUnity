using UnityEngine;

public class Porta : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private Transform LugarAnterior;
    [SerializeField] private Transform ProximoLugar;

    [SerializeField] private CameraController cam;


    void Awake()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            if (collision.transform.position.x < transform.position.x)
            {
                cam.moverParaNovoLugar(ProximoLugar);
            }
            else
            {
                cam.moverParaNovoLugar(LugarAnterior);

            }

        }
    }

}
