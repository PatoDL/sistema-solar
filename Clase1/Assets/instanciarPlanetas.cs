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
                p.GetComponent<pfPlaneta>().sol = sol;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
