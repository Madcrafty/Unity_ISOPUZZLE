using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int moveSpeed = 1;

    PlayerActions Controles;
    private CharacterController CC;

    private void Awake()
    {
        Controles = new PlayerActions();
    }

    private void OnEnable()
    {

        //Controles.Default.Move.performed += Move_performed;
        //Controles.Default.Move.Enable();
        Controles.Default.Up.performed += Up_performed;
        Controles.Default.Up.Enable();
        Controles.Default.Down.performed += Down_performed;
        Controles.Default.Down.Enable();
        Controles.Default.Left.performed += Left_performed;
        Controles.Default.Left.Enable();
        Controles.Default.Right.performed += Right_performed;
        Controles.Default.Right.Enable();
        //Controles.Enable();
    }

    private void Right_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        CC.Move(Vector3.right * Time.timeScale);
    }

    private void Left_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        CC.Move(Vector3.left * Time.timeScale);
    }

    private void Down_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        CC.Move(Vector3.back * Time.timeScale);
    }

    private void Up_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        CC.Move(Vector3.forward * Time.timeScale);
    }

    // Mobile Controles
    public void m_Right()
    {
        CC.Move(Vector3.right * Time.timeScale);
    }
    public void m_Left()
    {
        CC.Move(Vector3.left * Time.timeScale);
    }
    public void m_Forward()
    {
        CC.Move(Vector3.forward * Time.timeScale);
    }
    public void m_Back()
    {
        CC.Move(Vector3.back * Time.timeScale);
    }

    //private void Move_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    //{
    //    Debug.Log("OBJECT: " + obj.ReadValue<Vector2>().ToString());
    //    Debug.Log("CONTRO: " + Controles.Default.Move.ReadValue<Vector2>().ToString());


    //    //throw new System.NotImplementedException();
    //    if (obj.ReadValue<Vector2>() == Vector2.up)
    //    {

    //    }
    //    if (obj.ReadValue<Vector2>() == Vector2.down)
    //    {

    //    }
    //    if (obj.ReadValue<Vector2>() == Vector2.left)
    //    {

    //    }
    //    if (obj.ReadValue<Vector2>() == Vector2.right)
    //    {

    //    }
    //}

    private void OnDisable()
    {
        //Controles.Default.Move.performed -= Move_performed;
        //Controles.Default.Move.Disable();
        Controles.Default.Up.performed -= Up_performed;
        Controles.Default.Up.Disable();
        Controles.Default.Down.performed -= Down_performed;
        Controles.Default.Down.Disable();
        Controles.Default.Left.performed -= Left_performed;
        Controles.Default.Left.Disable();
        Controles.Default.Right.performed -= Right_performed;
        Controles.Default.Right.Disable();
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
        ////Read movement
        //float h_Input = Controles.Default.Horizontal.ReadValue<float>();
        //float v_Input = Controles.Default.Vertical.ReadValue<float>();
        ////Move Player

        //if (h_Input > 0)
        //{
        //    CC.Move(Vector3.right);
        //}
        //if (h_Input < 0)s
        //{
        //    CC.Move(Vector3.left);
        //}
        //if (v_Input > 0)
        //{
        //    CC.Move(Vector3.forward);
        //}
        //if (v_Input < 0)
        //{
        //    CC.Move(Vector3.back);
        //}
        if (CC.isGrounded == false)
        {
            CC.Move(Vector3.down);
        }


        //if (Controles.Default.Move.ReadValue<Vector2>() == Vector2.up)
        //{
        //    CC.Move(Vector3.forward);
        //}
        //if (Controles.Default.Move.ReadValue<Vector2>() == Vector2.down)
        //{
        //    CC.Move(Vector3.back);
        //}
        //if (Controles.Default.Move.ReadValue<Vector2>() == Vector2.left)
        //{
        //    CC.Move(Vector3.left);
        //}
        //if (Controles.Default.Move.ReadValue<Vector2>() == Vector2.right)
        //{
        //    CC.Move(Vector3.right);
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
