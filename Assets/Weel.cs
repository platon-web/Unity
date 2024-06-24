using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weel : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      float right =  Input.GetAxis("Horizontal");
      if(right!=0 ){
         var newPosition=transform.position;
         newPosition.x +=right;
         rigidbody2D.MovePosition(newPosition);
      }
           float right2 =  Input.GetAxis("Vertical");
      if(right2!=0 ){
         var newPosition=transform.position;
         newPosition.y +=right2;
         rigidbody2D.MovePosition(newPosition);
      }
    }
}
