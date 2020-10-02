using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBears : MonoBehaviour
{
    public GameObject bear;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());

    }
    IEnumerator spawn()
    {
        while (true)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Random.RandomRange(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
            Instantiate(bear, pos, Quaternion.identity);
            yield return new WaitForSeconds(5.01f); 
        }
    }
    
}
