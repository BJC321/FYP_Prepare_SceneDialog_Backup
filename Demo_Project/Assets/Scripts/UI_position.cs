using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_position : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Camera.main.transform.position + Vector3.Normalize(transform.position - Camera.main.transform.position));
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
        //transform.LookAt(Camera.main.transform.position, Camera.main.transform.rotation * Vector3.right );
        //transform.forward = transform.forward * -1f;
    }
}
