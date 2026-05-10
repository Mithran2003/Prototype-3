using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -10)
        {
            transform.Translate(47f,9.5f,4f);
        }   
    }
}
