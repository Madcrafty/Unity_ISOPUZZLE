using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float pauseInterval = 0.5f;
    public float waitTime = 2.0f; // Time the platform waits when it reaches the end of its path
    public GameObject path;
    public bool loop;
    public bool PlayerActivated;

    public Color ActiveColour;
    public Color WaitColour;

    private Transform[] points;
    private int iter = 0;
    private bool direction = true;
    private bool active = true;
    private float timer;
    private bool playerOn = false;
    private bool waiting = false;

    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        Transform[] xyz = new Transform[path.transform.childCount];
        for (int i = 0; i < path.transform.childCount; i++)
        {
            xyz[i] = path.transform.GetChild(i);
        }
        points = xyz;
        renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerActivated == true)
        {
            if (playerOn == true || (iter < points.Length - 1 && iter > 0))
            {
                // Continue
                renderer.material.color = ActiveColour;
            }
            else
            {
                renderer.material.color = WaitColour;
                return;
            }
        }
        timer += Time.deltaTime;
        if (waiting == true && timer >= waitTime)
        {
            waiting = false;
        }
        if (timer >= pauseInterval && waiting == false)
        {
            timer = 0;
            if (direction == true) iter++;
            if (direction == false) iter--;
            if (iter >= points.Length || iter < 0)
            {
                if (loop)
                {
                    waiting = true;
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
        if (waiting == true)
        {
            renderer.material.color = WaitColour;
        }
        else
        {
            renderer.material.color = ActiveColour;
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
