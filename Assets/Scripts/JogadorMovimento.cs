using UnityEngine;

public class JogadorMovimento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Rigidbody2D corpo;
    Animator anim;

    void Awake()
    {
        corpo = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        corpo.linearVelocity = new Vector2(x: Input.GetAxis("Horizontal") * 10, y: corpo.linearVelocityY);

        if (Input.GetKey(KeyCode.Space))
        {
            corpo.linearVelocity = new Vector2(x: Input.GetAxis("Horizontal") * 10, y: 5f);

        }

        float horizontalImput = Input.GetAxis("Horizontal");

        if (horizontalImput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalImput < -0.01f)
        {
            transform.localScale = new Vector3(x: -4, y: 4, z: 1);
        }
        anim.SetBool("Run", horizontalImput != 0);
}
