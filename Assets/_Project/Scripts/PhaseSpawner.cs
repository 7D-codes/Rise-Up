using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseSpawner : MonoBehaviour
{
    public GameObject phase;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPhase();
        }
    }

    public void SpawnPhase()
    {
        Instantiate(phase, transform.position = new Vector3(0, -15, 0), transform.rotation);
    }
}
