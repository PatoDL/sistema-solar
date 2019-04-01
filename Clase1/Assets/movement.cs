using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rig;
    public float force = 10;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rig=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float rSpeed = speed * Time.deltaTime;
        rig.AddForce(new Vector3(force * horizontal, 0, force * vertical),ForceMode.Force);
        //transform.position=new Vector3(transform.position.x + horizontal* rSpeed,transform.position.y,transform.position.z + vertical * rSpeed);   
    }
}
