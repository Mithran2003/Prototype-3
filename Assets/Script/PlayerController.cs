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
    private static bool GameOver = false;
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
            break;
        }
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *=GravityMultiplyer;
        
    }

    // Update is called once per frame
    void Update()
    {
        playerJump();
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
    
      
}
