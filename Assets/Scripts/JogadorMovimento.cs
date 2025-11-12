
using UnityEngine; // Importa o namespace fundamental da Unity.

public class PlayerMoviment : MonoBehaviour
{

    public float speed = 10f;
    public float jump = 5f;
    
    private Rigidbody2D body;
    private Animator anim;
    
    

    // Variável booleana para rastrear se o personagem está tocando o chão.
    private bool grounded;

    // Método chamado quando o script é carregado (antes de 'Start').
    private void Awake()
    {


        body = GetComponent<Rigidbody2D>();
      
        anim = GetComponent<Animator>();

    }

    // Método chamado a cada frame do jogo. Usado para lógica de jogo baseada em entrada.
    private void Update()
    {
        // Obtém a entrada horizontal (teclas 'A'/'D' ou setas) variando de -1 a 1.
        float horizontalInput = Input.GetAxis("Horizontal");

       
        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocityY);

        // Lógica para virar (flip) o sprite do jogador.

        // Se movendo para a direita (input positivo).
        if (horizontalInput > 0.01f)
        {
         
            transform.localScale = new Vector3(4, 4, 1);
        }
        // Se movendo para a esquerda (input negativo).
        else if (horizontalInput < -0.01f)
        {
          
            transform.localScale = new Vector3(-4, 4, 1);
        }

        // Verifica se a tecla 'Space' foi pressionada E se o personagem está no chão.
        
    
        
        //modificar esta parte
        if (Input.GetKey(KeyCode.Space) && grounded )
        {
          
            Jump();
        }

       
        anim.SetBool("run", horizontalInput != 0); 

        anim.SetBool("grounded", grounded);
        
        // pulo Parede
        
        // lógica do pulo parede 

    }

   
    private void Jump()
    {
      
        body.linearVelocity = new Vector2(body.linearVelocityX, jump);

        // Imediatamente marca 'grounded' como falso para evitar pulos duplos (no ar).
        grounded = false;
    }

   
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto com o qual o personagem colidiu tem a tag "Ground".
        if(collision.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }

}
