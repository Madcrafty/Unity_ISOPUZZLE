using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitLevel : MonoBehaviour
{
    public bool NextLevel;
    public int Level = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (NextLevel)
        {
            Level = SceneManager.GetActiveScene().buildIndex + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Exit Triggered");
        if (other.transform.tag == "Player")
        {
            Debug.Log("Load Scene");
            SceneManager.LoadScene(Level);
        }
    }
}
