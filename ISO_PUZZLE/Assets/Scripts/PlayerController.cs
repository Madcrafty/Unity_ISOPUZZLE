using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int moveSpeed = 1;

    private PlayerActions Controles;
    private CharacterController CC;

    private void Awake()
    {
        Controles = new PlayerActions();
    }

    private void OnEnable()
    {
        Controles.Enable();
    }

    private void OnDisable()
    {
        Controles.Disable();
    }
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
        //Read movement
        float h_Input = Controles.Default.Horizontal.ReadValue<float>();
        float v_Input = Controles.Default.Vertical.ReadValue<float>();
        //Move Player

        if (h_Input > 0)
        {
            CC.Move(Vector3.right);
        }
        if (h_Input < 0)
        {
            CC.Move(Vector3.left);
        }
        if (v_Input > 0)
        {
            CC.Move(Vector3.forward);
        }
        if (v_Input < 0)
        {
            CC.Move(Vector3.back);
        }
        if (CC.isGrounded == false)
        {
            CC.Move(Vector3.down);
        }

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    CC.Move(Vector3.right);
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    CC.Move(Vector3.left);
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    CC.Move(Vector3.forward);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    CC.Move(Vector3.back);
        //}
        //if (CC.isGrounded == false)
        //{
        //    CC.Move(Vector3.down);
        //}
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
