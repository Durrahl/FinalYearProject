using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciever : MonoBehaviour
{

    public bool isBeingStoodOn = false;
    public StatManager stsMngr;
    
    // Start is called before the first fframe update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collid");

        if (col.gameObject.tag == "Block")
        {
            LayerMask mask = LayerMask.GetMask("areacube");
            if (Physics.CheckSphere(this.transform.position + new Vector3(0, 0.5f, 0), 0.4f, mask))
            {
                Debug.Log("Scored");
                stsMngr.Score += 10;
            }
        }

        Destroy(col.gameObject);
    }
}
