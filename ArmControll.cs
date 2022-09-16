using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControll : MonoBehaviour
{
    [SerializeField]

    /*
     * 
     * 
     * TANK SHOULD BE FACING TOWARDS +X
     * 
     * 
     */
    float rotationSpeed = 60;
    Vector3 angles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.U))
        { 
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }

        angles = transform.localRotation.eulerAngles;

        if (angles.x > 25 && angles.x < 180)
        {
            transform.localRotation = Quaternion.Euler(25, 0, 0);
        }
        if (angles.x < 300 && angles.x > 180)
        {
            transform.localRotation = Quaternion.Euler(300, 0, 0);
        }
    }
}
