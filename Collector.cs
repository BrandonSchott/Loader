using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField]
    GameObject bucket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bucket.transform.rotation.eulerAngles.z >= 290 && bucket.transform.rotation.eulerAngles.z <= 360)
        {
            transform.DetachChildren();
        }
        Debug.Log(bucket.transform.rotation.eulerAngles.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Ball")
        {
            other.transform.parent = transform;
        }
    }
}
