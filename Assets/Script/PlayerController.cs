using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private bool IsGrounded = true ;
    private Rigidbody playerRB;
    [SerializeField]
    private float JumpForce;
    [SerializeField]
    private float GravityMultiplyer;
    private Animator PlayerAnimator;
    private static bool GameOver = false;
    private Vector3 PlayerPosition ;
    public static bool  GetGameStatues()

    {
        return GameOver;
    }
   
    private void playerJump()
    {
        while((Input.GetKeyDown(KeyCode.Space))&& IsGrounded)
        {
            playerRB.AddForce(Vector3.up* JumpForce,ForceMode.Impulse);
            IsGrounded = false;
            PlayerAnimator.SetTrigger("Jump_trig");
            break;
        }
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *=GravityMultiplyer;
        PlayerAnimator = GetComponent<Animator>(); 
        PlayerPosition =  new Vector3 (-0.5f,0,0);       
    }

    // Update is called once per frame
    void Update()
    {
        playerJump();
        if(transform.position.x >0  )
        {
            StartCoroutine(LeftForce());
        }
            
        if(transform.position.x <0 )
        {
            StartCoroutine(RightForce());
        }
        if(transform.position.x >0.5f && transform.position.x <-0.5f)
        {
            StopCoroutine(LeftForce());
            StopCoroutine(LeftForce());
        }
    }

     private void OnCollisionEnter(Collision other)
     {
        
        if(other.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;          
        }

        else if(other.gameObject.CompareTag("Obstacle"))
        {
            GameOver = true;
            Debug.Log("Game Over !");
        }

     }
    IEnumerator LeftForce()
    {
        if(transform.position.x > 0)
        {
            playerRB.AddForce(Vector3.left* 15000 * Time.deltaTime,ForceMode.Impulse);
        }
        yield return new WaitForSeconds(0f);
    }
    IEnumerator RightForce()
    {
        if(transform.position.x <0)
        {
            playerRB.AddForce(Vector3.right* 1500 * Time.deltaTime,ForceMode.Impulse);
        }
        yield return new WaitForSeconds(0f);
    }
    
      
}
