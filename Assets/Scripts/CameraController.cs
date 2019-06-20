using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public float offset;
    private Vector3 cameraPosition;
    public float switchTime;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

        if (player.transform.localScale.x > 0f)
        {
            cameraPosition = new Vector3(cameraPosition.x + offset, cameraPosition.y, cameraPosition.z);


        }
        else
        {
            
            cameraPosition = new Vector3(cameraPosition.x - offset, cameraPosition.y, cameraPosition.z);
        }

        transform.position = Vector3.Lerp(transform.position, cameraPosition, switchTime * Time.deltaTime );
    }
}
