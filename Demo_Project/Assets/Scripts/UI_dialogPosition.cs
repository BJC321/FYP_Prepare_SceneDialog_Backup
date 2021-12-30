using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_dialogPosition : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Camera.main.transform.position + Vector3.Normalize(transform.position - Camera.main.transform.position));
        transform.LookAt(target);
        transform.forward = transform.forward * -1f;
    }
}
