using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D part;
    [SerializeField]
    private float speed;
    [SerializeField]
    private KeyCode keyCode;
    [SerializeField]
    private float force;

    void Start()
    {
      part = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(keyCode))
      {
          part.velocity = new Vector2(part.velocity.x, speed);
      }
    }
}
