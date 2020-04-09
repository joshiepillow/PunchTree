using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFunctions : MonoBehaviour
{
    public static Vector2 findDirect(float x, float y) {
        float Hypotenuse = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        return new Vector2(x/Hypotenuse, y/Hypotenuse);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
