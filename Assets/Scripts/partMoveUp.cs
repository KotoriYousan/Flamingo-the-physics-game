using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partMoveUp : MonoBehaviour
{

    private Rigidbody2D part;
    [SerializeField]
    private float speed;
    [SerializeField]
    private KeyCode keyCode;

    float force = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        part = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyCode))
        {
            //float move = Input.GetAxisRaw("Vertical");
            //transform.Translate(Vector2.up * speed * Time.deltaTime);
            //part.AddForce(Vector2.up * force);
            part.velocity = new Vector2(part.velocity.x, speed);
        }
    }
}
