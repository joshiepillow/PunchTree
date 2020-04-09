using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera camera;
    public float speed;
    public Sprite[] Directions;

    private int spriteNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        int x, y;
        x = y = 0;
        if (Input.GetMouseButtonDown(0)) {
            Vector2 pos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) - gameObject.transform.position;
            GameObject attackObj  = new GameObject("attack");
            attackObj.transform.position = gameObject.transform.position;
            attackObj.AddComponent<PlayerAttack>();
            attackObj.GetComponent<PlayerAttack>().Init(pos);
        }
        if (Input.GetKey(KeyCode.W)) y += 1;
        if (Input.GetKey(KeyCode.S)) y -= 1;   
        if (Input.GetKey(KeyCode.A)) x -= 1;
        if (Input.GetKey(KeyCode.D)) x += 1;

        //Debug.Log(x + " " + y);
        int newSpriteNum = 3*y + x + 4;
        if (newSpriteNum != spriteNumber && newSpriteNum != 4) {
            spriteNumber = newSpriteNum;
            GetComponent<SpriteRenderer>().sprite = Directions[spriteNumber];
        }
        transform.position += new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime, 0);
    }
}
