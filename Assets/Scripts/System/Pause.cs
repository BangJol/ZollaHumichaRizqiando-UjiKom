using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Paused()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
        }
    }

    public void Status()
    {
        // SetTimeScale == 0;
    }
}
