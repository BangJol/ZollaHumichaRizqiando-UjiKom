using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float flyingSpd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Flying();
        Duration();
    }

    public void Flying()
    {
        transform.TransformDirection(Vector3.forward * 10);
        transform.position = transform.position + new Vector3(0, 0, flyingSpd * Time.deltaTime);

    }

    // void OnTriggerEnter(Collider collider)
    // {
    //     if (other.GameObject.CompareTag("Animal"))
    //     {
    //         Destroy(this);
    //     }
    // }

    public void Duration()
    {
        Destroy(gameObject, 3);
    }
}
