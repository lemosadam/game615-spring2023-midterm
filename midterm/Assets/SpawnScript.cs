using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    float lastlaunchTime = 0;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastlaunchTime > 5f)
        {
            Instantiate(fire,gameObject.transform.position, transform.rotation);
            lastlaunchTime = Time.time;
            Debug.Log("timer switch");
        }
    }
}
