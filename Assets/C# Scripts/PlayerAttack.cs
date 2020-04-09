using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void Init() {

    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Attack");
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
