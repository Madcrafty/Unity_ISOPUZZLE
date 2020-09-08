using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuActions : MonoBehaviour
{
    public GameObject startMenu;
    public bool pause_menu = false;

    private GameObject activeMenu;
    private PlayerActions Controles;
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
        activeMenu = startMenu;
    }

    // Update is called once per frame
    void Update()
    {
        if (pause_menu)
        {
            float p_Input = Controles.Default.Pause.ReadValue<float>();
            if (p_Input > 0)
            {
                Toggle();
            }
        }
    }
    public void Toggle()
    {
        activeMenu.SetActive(!activeMenu.activeSelf);
    }
    public void SetScene(int Level)
    {
        Debug.Log("Load Scene");
        SceneManager.LoadScene(Level);
    }
    public void SetMenu(GameObject menu)
    {
        activeMenu.SetActive(false);
        activeMenu = menu;
        activeMenu.SetActive(true);
    }
    public void CloseApp()
    {
        Application.Quit();
    }
}
