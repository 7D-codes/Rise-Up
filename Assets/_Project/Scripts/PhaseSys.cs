using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhaseSys : MonoBehaviour
{
    GameHandler gh;

    void Start()
    {
        gh = GameObject.Find("GameHandler").GetComponent<GameHandler>();

        
    }

    void FixedUpdate()
    {
        gameObject.transform.Translate(0, gh.Speed * Time.deltaTime, 0);
    }

}
