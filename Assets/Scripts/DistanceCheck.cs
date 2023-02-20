using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCheck : MonoBehaviour
{
    public GameObject PultLocation;
    public GameObject CatLocation;
    public Text text;
    public string DistanceText;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(PultLocation.transform.position, CatLocation.transform.position);

        Debug.Log("Distance: " + distance);
        string DistanceText = distance.ToString();
        //text.text = DistanceText;
        //Why not check the distance, and then do an if statement that applies a slowdown if it goes above X distance?
    }
}
