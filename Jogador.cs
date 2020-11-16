using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float Velocidade2 = 10.0f;
    public float HorizontalAxis;
    public Rigidbody2D rigidbody1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalAxis = Input.GetAxis("Horizontal");
        rigidbody1.velocity = new Vector2 (Velocidade2 * HorizontalAxis, 0);
    }
}
