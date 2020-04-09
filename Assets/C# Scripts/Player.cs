using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Debug.Log(x + " " + y); 

        transform.position += new Vector3(x, y, 0);
    }
}
