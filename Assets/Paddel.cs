using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel : MonoBehaviour
{

    [SerializeField] KeyCode up;
    [SerializeField] KeyCode down;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up) && transform.position.y < 3)
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
        }

        if (Input.GetKey(down) && transform.position.y > -3)
        {
            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;
        }
    }
}
