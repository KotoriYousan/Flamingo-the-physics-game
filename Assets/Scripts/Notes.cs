using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
  	private Transform pOO;
  	[SerializeField]
  	private Transform pDD;
    [SerializeField]
  	private  float speed;
  	private Vector3 pO, pD;

    void Start()
    {
      pO = new Vector3 (pOO.position.x,transform.position.y,transform.position.z);
  		pD = new Vector3 (pDD.position.x,transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.x <= pD.x) {
        transform.position = pO;
      }
      else {
        transform.position = Vector3.MoveTowards(transform.position, pD, speed*Time.deltaTime);
      }
    }
}
