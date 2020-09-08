using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float pauseInterval = 1.0f;
    public GameObject path;
    public bool loop;
    public bool PlayerActivated;

    private Transform[] points;
    private int iter = 0;
    private bool direction = true;
    private bool active = true;
    private float timer;
    private bool playerOn = false;
    // Start is called before the first frame update
    void Start()
    {
        Transform[] xyz = new Transform[path.transform.childCount];
        for (int i = 0; i < path.transform.childCount; i++)
        {
            xyz[i] = path.transform.GetChild(i);
        }
        points = xyz;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerActivated == true)
        {
            if (playerOn == true || (iter < points.Length - 1 && iter > 0))
            {
                // Continue
            }
            else return;
        }
        timer += Time.deltaTime;
        if (timer >= pauseInterval)
        {
            timer = 0;
            if (direction == true) iter++;
            if (direction == false) iter--;
            if (iter >= points.Length || iter < 0)
            {
                if (loop)
                {
                    direction = !direction;
                    if (direction == true) iter++;
                    if (direction == false) iter--;
                }
                if (!loop)
                {
                    this.enabled = false;
                    active = false;
                }

            }
            if(active) transform.position = points[iter].position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOn = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOn = false;
        }
    }
}
