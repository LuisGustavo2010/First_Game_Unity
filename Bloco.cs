using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
public Rigidbody2D rigidbody1;
public BoxCollider2D collider1;


     void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D> ();
        collider1 = GetComponent<BoxCollider2D> ();
    }

  void OnCollisionEnter2D(Collision2D collision) 
   {
      rigidbody1.constraints = new RigidbodyConstraints2D ();
      collider1.isTrigger = true;
    }
}