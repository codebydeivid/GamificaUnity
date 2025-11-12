using UnityEngine;

public class CameraController : MonoBehaviour
{
    // mover a camera através das fases 

     [SerializeField] private float speed;
   private float currentPosX;

    private Vector3 velocity = Vector3.zero;

    // follow player

    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;

    [SerializeField] private float cameraSpeed;

    [SerializeField] private float yOffset = 1.5f; 
    
    // Ajuste este valor no Inspector

    private float lookAhead;


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // room camera

        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);



       // transform.position = new Vector3(player.position.x + lookAhead, player.position.y + yOffset,-10);

        //float targetLookAhead = aheadDistance * player.localScale.x;
        //lookAhead = Mathf.Lerp(lookAhead, targetLookAhead, Time.deltaTime * cameraSpeed);





    }


    public void moverParaNovoLugar(Transform _novoLugar)
    {
        currentPosX = _novoLugar.position.x;
    }
}
