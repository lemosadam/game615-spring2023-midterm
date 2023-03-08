using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    float forwardSpeed = 10f;
    float rotateSpeed = 50f;
    public GameManager gm;
    public TMP_Text loseText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * forwardSpeed * vAxis, Space.World);
        gameObject.transform.Rotate(0,rotateSpeed * Time.deltaTime * hAxis, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 'other' is the name of the collider that just collided with the object
        // that this script ("PlayerController") is attached to. So the if statment
        // below checks to see that that object has the tag "coin". Remember that
        // the tags for GameObjects are assigned in the top left area of the
        // inspector when you select the obect.
        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            gm.IncrementScore();
            Debug.Log("collided");
        }

        if (other.CompareTag("fire"))
        {
            Destroy(gameObject);
            loseText.text = "You Died!";

        }

    }
}