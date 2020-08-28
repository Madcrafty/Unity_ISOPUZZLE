﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int moveSpeed = 1;

    private CharacterController CC;
    // Start is called before the first frame update
    void Start()
    {
        CC = GetComponent<CharacterController>();
        if (CC == null)
        {
            Debug.LogError("Requires character controller component");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            CC.Move(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            CC.Move(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            CC.Move(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            CC.Move(Vector3.back);
        }
        if (CC.isGrounded == false)
        {
            CC.Move(Vector3.down);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        if (other.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.gameObject.tag == "Platform")
        {
            transform.parent = null;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            transform.parent = other.transform;
        }
    }
}
