using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayercam : MonoBehaviour
{
    public GameObject Draje;
    public Vector3 offset = new Vector3 (0, 5, 3);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Draje.transform.position + offset;
    }
}
