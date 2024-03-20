using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class camera_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tr; 
    void Start()
    {

    }
    float angularSpeed = 2f;
    float positionX, positionY, angle = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            positionX = tr.position.x + Mathf.Cos(angle) * (this.transform.position.x - tr.position.x);
            positionY = tr.position.z + Mathf.Cos(angle) * (this.transform.position.z - tr.position.z);
            this.transform.position = new Vector3 (positionX,1, positionY);
            angle = angle + Time.deltaTime *angularSpeed;
            if (angle >=360f)
            {
                angle = 0f;
            }
        }
            
    }
}
