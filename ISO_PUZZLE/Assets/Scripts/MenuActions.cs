using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuActions : MonoBehaviour
{
    public GameObject startMenu;
    public bool pause_menu = false;

    private GameObject activeMenu;
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
            if (Input.GetKeyDown(KeyCode.Escape))
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
