using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    private Vector3 startPos;
    private int num_pressurePlates;
    private int pressed = 0;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        GameObject[] pressurePlates = GameObject.FindGameObjectsWithTag("PressurePlate");

        foreach (GameObject Plate in pressurePlates)
        {
            num_pressurePlates++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PresurePlate()
    {
        pressed++;
        if (num_pressurePlates == pressed)
        {
            Open();
        }
    }

    public void Open()
    {
        transform.position = startPos + new Vector3(0, 2, 0);
    }

    public void Close()
    {
        transform.position = startPos;
    }
}
