using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    [Header("Player stats")]

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] public bool isGrounded;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;
    [SerializeField] Transform groundCheck2;
    [SerializeField] Transform groundCheck3;
    [SerializeField] Sprite Joump;
    [SerializeField] Sprite ron;
    [SerializeField] Sprite Stand;
    Vector2 moveVector;

    Rigidbody2D playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }



    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)
        {

            
            Jump(); 
        }


    }




    public void OnMove(InputAction.CallbackContext context)
    {
       moveVector = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        playerRb.linearVelocity = new Vector2(moveVector.x * moveSpeed, playerRb.linearVelocity.y);
    }


    void Jump()
    {
        playerRb.linearVelocityY = 0;
        playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D .Impulse);
    }


    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer)|| Physics2D.OverlapCircle(groundCheck2.position, 0.2f, groundLayer)|| Physics2D.OverlapCircle(groundCheck3.position, 0.2f, groundLayer);
    }


    private void OnDrawGizmosSelected()
    {

        if (isGrounded)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color= Color.red;
        }




        Gizmos.DrawWireSphere(groundCheck.position, 0.2f);

    }






}
