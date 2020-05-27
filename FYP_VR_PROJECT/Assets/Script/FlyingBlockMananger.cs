using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBlockMananger : MonoBehaviour
{
    // Start is called before the first frame update
    public float blockSpeed = 1.0f;
    public Rigidbody thisRB;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        thisRB.velocity = new Vector3(0, 0, -1 * blockSpeed);

        if (this.transform.position.z < -15)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        StatManager txtCont = GameObject.FindObjectOfType<StatManager>();
        txtCont.Score += 10;
        Destroy(this.gameObject);
    }
}
