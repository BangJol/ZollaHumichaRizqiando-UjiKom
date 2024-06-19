using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Cow;
    public GameObject Dog;
    public GameObject Horse;
    public GameObject Deer;

    public float Interval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }

    public void spawn()
    {
        Instantiate(Cow);
        Instantiate(Dog);
        Instantiate(Horse);
        Instantiate(Deer);
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Interval);
        // Instantiate(Random(Cow, Dog, Horse, Deer), new Vector3(0,0,0));
    }
}
