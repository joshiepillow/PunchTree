using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Vector2 moveEach;
    private int speed;

    public void Init(Vector2 clickPos) {
        gameObject.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Attack");
        moveEach = GlobalFunctions.findDirect(clickPos.x, clickPos.y);
        speed = 1;
    } 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveEach.x * speed * Time.deltaTime, moveEach.y * speed * Time.deltaTime, 0);
    }
}
