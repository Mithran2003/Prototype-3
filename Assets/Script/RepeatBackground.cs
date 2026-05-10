using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 OrignalPosition;
    private float RepeatWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        OrignalPosition = transform.position;
        RepeatWidth = GetComponent<BoxCollider>().size.x/2 ;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < (OrignalPosition.x - RepeatWidth))
        {
            transform.position = OrignalPosition;
        }   
    }
}
