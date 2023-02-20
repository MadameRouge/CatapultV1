using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseTrack : MonoBehaviour
{
    private GameObject Manager;
    public GameObject OriginCat;
    public int Phase;

    public GameObject Catapult;
    public GameObject PhaseOne;

    public GameObject P1Cam;
    public GameObject P2Cam1;
    public GameObject P2Cam2;

    private bool TChecker;

    private int Time;
    private bool TimeChecker;
    //PUT IN START
    //To trigger items tracking - Manager = GameObject.FindGameObjectWithTag("Manager");

    //PUT IN UPDATE
    //Manager.GetComponent<ScriptName>(); - Redundant
    //Manager.GetComponent<ScriptName>().FunctionName();

    // Start is called before the first frame update
    void Start()
    {
        Phase = 1;
        Catapult.GetComponent<Fire>().enabled = false;
        Time = 299;
        TimeChecker = false;
        TChecker = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TChecker == true)
        {
            if (Time >= 0)
            {
                Time = Time - 1;
            }
            else
            {
                TimeChecker = true;
            }
        }

        Debug.Log(Phase);
        if (Phase == 1)
        {
            P1Cam.active = true;
            P2Cam1.active = false;
            P2Cam2.active = false;
            PhaseOne.GetComponent<Select>().enabled = true;
            Catapult.GetComponent<Fire>().enabled = false;
        }
        else if (Phase == 2)
        {
            P1Cam.active = false;
            if (TimeChecker == true)
            {
                //OriginCat.active = false;
                P2Cam1.active = false;
                P2Cam2.active = true;
            }
            else if (TimeChecker == false)
            {
                P2Cam2.active = true;
                P2Cam1.active = true;
            }
            PhaseOne.GetComponent<Select>().enabled = false;
            Catapult.GetComponent<Fire>().enabled = true;
        }
    }

    public void PhaseUpdater()
    {
        Debug.Log("TestUpdater");
        Phase += 1;
    }

    public void EnableTimer()
    {
        TChecker = true;
    }
}
