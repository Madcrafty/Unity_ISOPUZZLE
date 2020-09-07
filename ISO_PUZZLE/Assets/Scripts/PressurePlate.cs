using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class PressurePlateEvent : UnityEvent { };

public class PressurePlate : MonoBehaviour
{

    public PressurePlateEvent onActivate;
    public PressurePlateEvent onDeactivate;

    public Color ActiveColour;
    public Color PressedColour;

    private bool pressed = false;
    private Collider bc;
    private Material material;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider>();
        gameObject.GetComponent<Renderer>().material.color = ActiveColour;
        //material.color = ActiveColour;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool PressurePlatePressed()
    {
        return pressed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            onActivate.Invoke();
            gameObject.GetComponent<Renderer>().material.color = PressedColour;
            this.enabled = false;
            bc.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            onDeactivate.Invoke();
        }
    }
}
