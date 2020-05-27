using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollower : MonoBehaviour
{
    public GameObject head;
    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(head.transform.position.x, 0.3f, head.transform.position.z);
    }
}
