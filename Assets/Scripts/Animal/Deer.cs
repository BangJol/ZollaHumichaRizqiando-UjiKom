using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : MonoBehaviour
{
    public float HungerNeed;
    public float Target = 200f;
    public float spd = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        // A = GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        Done();
        Run();
    }

    public void Done()
    {
        if(HungerNeed == Target)
        {
            // A.AddScore(2);
            Destroy(this);
        }
    }

    public void Run()
    {
        transform.position = transform.position + new Vector3(0, 0, -spd * Time.deltaTime);
    }
}
