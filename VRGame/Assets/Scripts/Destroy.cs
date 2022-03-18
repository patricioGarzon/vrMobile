using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update

    public LayerMask layer;
    private Vector3 previousPs;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer)) ;
        {
            if(Vector3.Angle(transform.position-previousPs,hit.transform.up)>130)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        previousPs = transform.position;
    }
}
