using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    private GameObject Manager;
    public GameObject CatCube;
    public Material Cat1;
    public Material Cat2;
    public Material Cat3;
    public Material Cat4;
    // Start is called before the first frame update
    void Start()
    {
        //THIS IS PHASE 1
        Manager = GameObject.FindGameObjectWithTag("Manager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            CatCube.GetComponent<MeshRenderer>().material = Cat1;
            Manager.GetComponent<PhaseTrack>().PhaseUpdater();
        }
        else if (Input.GetKey("2"))
        {
            CatCube.GetComponent<MeshRenderer>().material = Cat2;
            Manager.GetComponent<PhaseTrack>().PhaseUpdater();
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            CatCube.GetComponent<MeshRenderer>().material = Cat3;
            Manager.GetComponent<PhaseTrack>().PhaseUpdater();
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            CatCube.GetComponent<MeshRenderer>().material = Cat4;
            Manager.GetComponent<PhaseTrack>().PhaseUpdater();
        }
    }
}
