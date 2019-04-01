using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciarPlanetas : MonoBehaviour
{
    public Transform planeta;
    public Transform sol;
    const int cantPlanetas = 8;

    // Start is called before the first frame update
    void Start()
    {
        if(planeta)
        {
            for(int i=0;i<cantPlanetas; i++)
            {
                Transform p = Instantiate(planeta);
                p.GetComponent<pfPlaneta>().radio = i * 10;
                p.transform.position = new Vector3(sol.transform.position.x, sol.transform.position.y,
                    sol.transform.position.z + p.GetComponent<pfPlaneta>().radio);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
