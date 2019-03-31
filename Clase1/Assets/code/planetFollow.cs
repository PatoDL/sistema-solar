using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetFollow : MonoBehaviour
{
    const int cantPlanetas = 9;

    float timer = 0;

    public GameObject sol;

    public GameObject[] planetas = new GameObject[cantPlanetas];

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = new Vector3(sol.transform.position.x,
            sol.transform.position.y + sol.transform.localScale.y + 3, sol.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            timer = 0;
            i++;
        }
        if(i==cantPlanetas)
        {
            i = 0;
        }


        Camera.main.transform.position = new Vector3(planetas[i].transform.position.x,
           planetas[i].transform.position.y - planetas[i].transform.localScale.y*2, planetas[i].transform.position.z);
    }
}
