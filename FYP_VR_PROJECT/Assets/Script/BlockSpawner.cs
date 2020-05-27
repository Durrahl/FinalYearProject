using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public float moveSpeed = 1.0f;
    public float speedIncrease = 0.001f;
    public float coolDownRed = 1.0f;
    public float coolDownBlue = 1.0f;
    public float coolDownGreen = 1.0f;
    public float coolDownFlying = 1.0f;
    float spawnCounterFlying = 1.0f;
    float spawnCounterRed = 1.0f;
    float spawnCounterBlue = 1.0f;
    float spawnCounterGreen = 1.0f;
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        spawnCounterRed = coolDownRed;
        spawnCounterGreen = coolDownGreen;
        spawnCounterBlue = coolDownBlue;
    }

    // Update is called once per frame
    void Update()
    {

        moveSpeed += speedIncrease;

        if (spawnCounterRed < 0)
        {
            // Spawn 1
            GameObject cube = Instantiate(cubes[0], this.transform.position + new Vector3(-0.5f, 0.5f, 0), this.transform.rotation);
            cube.GetComponent<BlockMover>().blockSpeed = moveSpeed;
            spawnCounterRed = coolDownRed;
        }

        if (spawnCounterGreen < 0)
        {
            // Spawn 2
            GameObject cube = Instantiate(cubes[1], this.transform.position + new Vector3(0, 0.5f, 0), this.transform.rotation);
            cube.GetComponent<BlockMover>().blockSpeed = moveSpeed;
            spawnCounterGreen = coolDownRed;
        }

        if (spawnCounterBlue < 0)
        {
            // Spawn 3
            GameObject cube = Instantiate(cubes[2], this.transform.position + new Vector3(0.5f, 0.5f, 0), this.transform.rotation);
            cube.GetComponent<BlockMover>().blockSpeed = moveSpeed;
            spawnCounterBlue = coolDownRed;
        }

        if (spawnCounterFlying < 0)
        {
            GameObject cube = Instantiate(cubes[3], this.transform.position + new Vector3(Random.Range(-0.5f, 0.5f), 2, 0), this.transform.rotation);
            cube.GetComponent<BlockMover>().blockSpeed = moveSpeed;
            spawnCounterFlying = coolDownFlying;
        }

       

        spawnCounterBlue -= Time.deltaTime;
        spawnCounterRed -= Time.deltaTime;
        spawnCounterGreen -= Time.deltaTime;
        spawnCounterFlying -= Time.deltaTime;
    }
}
