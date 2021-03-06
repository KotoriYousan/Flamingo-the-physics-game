using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointL : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _joint;
    [SerializeField]
  	private  float speed;
    void Start()
    {
      _joint = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      float moveX = Input.GetAxisRaw("Horizontal");
      float moveY = Input.GetAxisRaw("Vertical");
      //move up
      if (Input.GetKey (KeyCode.W)) {
         //transform.Translate (Vector2.up * speed * Time.deltaTime);
         _joint.velocity = new Vector2 ( _joint.velocity.x, moveY*speed);
      }
      //move down
      if (Input.GetKey (KeyCode.S)) {
         //transform.Translate (Vector2.down * speed * Time.deltaTime);
         _joint.velocity = new Vector2 ( _joint.velocity.x, moveY*speed);
      }
      //move LEFT
      if (Input.GetKey (KeyCode.A)) {
         //transform.Translate (Vector2.left * speed * Time.deltaTime);
         _joint.velocity = new Vector2 ( moveX*speed, _joint.velocity.y);
      }
      //move RIGHT
      if (Input.GetKey (KeyCode.D)) {
         //transform.Translate (Vector2.right * speed * Time.deltaTime);
         _joint.velocity = new Vector2 ( moveX*speed, _joint.velocity.y);
      }
    }
}
