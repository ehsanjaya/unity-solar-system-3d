using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public float R;
    public float Time;
    public GameObject point;
    public Transform player;
    public Text textDistance;
    public Text textTime;
    public ControlPlayerMobile controlPlayerMobile = new ControlPlayerMobile();
    public LineRenderer lr;
    public bool isDrawing = false;
    public string namePlanet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        R = Mathf.Sqrt(point.transform.position.x * point.transform.position.x + point.transform.position.y * point.transform.position.y + point.transform.position.z * point.transform.position.z);
        textDistance.text = "Distance: Player -> " + point.name + ": " + R + " KM";
        Time = R / controlPlayerMobile.speedMove;
        textTime.text = "Time: " + Time + " Minute";
        if (isDrawing == true)
        {
            point = GameObject.Find(namePlanet.ToString());
            lr.positionCount = 2;
            lr.SetPosition(0, new Vector3(player.position.x, player.position.y, player.position.z));
            lr.SetPosition(1, new Vector3(point.transform.position.x, point.transform.position.y, point.transform.position.z));
        }
        else
        {
            lr.positionCount = 0;
        }
    }
}
