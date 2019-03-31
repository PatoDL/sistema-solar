using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon : MonoBehaviour
{

    public float speed;
    public int radio;

    float actualPos;
    float newx, newy, newz;

    public GameObject planeta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actualPos += Time.deltaTime * speed;

        newx = planeta.transform.position.x + radio * Mathf.Cos(actualPos);
        newz = planeta.transform.position.z + radio * Mathf.Sin(actualPos);
        newy = planeta.transform.position.y + radio * Mathf.Sin(actualPos);
        transform.position = new Vector3(newx, transform.position.y, newz);
    }
}
