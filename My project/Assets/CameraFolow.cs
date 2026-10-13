using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    public Transform player;
    public float CameraSpeed;
    public float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate(){
        if(player!=null){
            Vector2 newCamPosition=Vector2.Lerp(transform.position, player.position, CameraSpeed*Time.deltaTime);
            float targetX=Mathf.Clamp(newCamPosition.x, minX, maxX);
            float targetY=Mathf.Clamp(newCamPosition.y, minY, maxY);
            transform.position=new Vector3(targetX,targetY,-10f);
           
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
