using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 velocidade;

    void Start()
    {
        rb2d.velocity = velocidade;
    }

    
    void Update()
    {
        
    }
}
