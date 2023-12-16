using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizonalLength;

    
    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizonalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundHorizonalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizonalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }


}
