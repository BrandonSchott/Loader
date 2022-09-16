using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour
{

    /*
     * 
     * 
     * TANK SHOULD BE FACING TOWARDS +X
     * 
     * 
     */

    [SerializeField]
    float rotationSpeed = 60;
    Vector3 angles;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
      
        if (Input.GetKey(KeyCode.I))
        {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K))
        {
                transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }

        angles = transform.localRotation.eulerAngles;

        if(angles.z > 40 && angles.z < 90)
        {
            transform.localRotation = Quaternion.Euler(0, -90, 40);
        }
        if (angles.z < 290 && angles.z > 180)
        {
            transform.localRotation = Quaternion.Euler(0, -90, 290);
        }
    }
}
