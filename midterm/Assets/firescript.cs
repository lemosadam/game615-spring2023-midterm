using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firescript : MonoBehaviour
{
    float forwardSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        // 'other' is the name of the collider that just collided with the object
        // that this script ("PlayerController") is attached to. So the if statment
        // below checks to see that that object has the tag "coin". Remember that
        // the tags for GameObjects are assigned in the top left area of the
        // inspector when you select the obect.
        if (other.CompareTag("wall"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("player"))
        {
            Destroy(other.gameObject);
        }

    }
}
