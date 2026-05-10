using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    [SerializeField]
    private float XDestroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <XDestroy)
        {
            Destroy(gameObject);
        }
        if(PlayerController.GetGameStatues()==true)
        {
            Destroy(gameObject);
        }
           
    }
}
