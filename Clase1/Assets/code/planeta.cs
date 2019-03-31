using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeta : MonoBehaviour
{
    public string planetName;
    public float speed;
    public int radio;

    float actualPos;
    float newx, newz;

    public GameObject sol;

    const int axis = 3;

   float[] anguloRotacion = new float [axis];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Este planeta se llama: " + planetName);

        transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);

        actualPos = Random.Range(-180.0f, 180.0f);

        for(int i=0;i<anguloRotacion.Length;i++)
        {
            anguloRotacion[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        newx = sol.transform.position.x + radio * Mathf.Cos(actualPos);
        newz = sol.transform.position.z + radio * Mathf.Sin(actualPos);
        transform.position = new Vector3(newx, transform.position.y, newz);

        actualPos += Time.deltaTime * speed;

        transform.Rotate(new Vector3(anguloRotacion[0], anguloRotacion[1], anguloRotacion[2]));

        for (int i = 0; i < anguloRotacion.Length; i++)
        {
            if (anguloRotacion[i] < 1)
            {
                anguloRotacion[i] += Time.deltaTime;
            }
        }
    }
}
