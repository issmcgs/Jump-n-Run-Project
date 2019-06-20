using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public Sprite checkpointReached;
    public Sprite checkpointUnReached;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool isCheckpointReached;



    // Start is called before the first frame update
    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HeroPlayer")
        {
            checkpointSpriteRenderer.sprite = checkpointReached;
            isCheckpointReached = true;

        }
    }
}
