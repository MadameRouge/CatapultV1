using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private GameObject Manager;
    public GameObject CopyCat;
    public Transform FirePoint;
    private int Time;
    private bool TimeChecker;
    public GameObject Pult;
    // Transform is the firepoint

    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
        Time = 300;
        TimeChecker = true;
        // Originally 3

    }

    // Update is called once per frame
    void Update()
    {
        // player presses spacebar
        // Do stuff
        if (Time >= 0)
        {
            Time = Time - 1;
            TimeChecker = false;
        }
        else
        {
            TimeChecker = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Manager.GetComponent<PhaseTrack>().EnableTimer();
            Pult.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 360 * 10);
            if (TimeChecker == true)
            {
                GameObject clone;
                clone = Instantiate(CopyCat, FirePoint.position, FirePoint.rotation);
                TimeChecker = false;
                Time = 300;

                clone.GetComponent<CatVel>().enabled = true;
                clone.gameObject.tag = "Player";
                clone.gameObject.active = true;
            }
        }
    }
}
