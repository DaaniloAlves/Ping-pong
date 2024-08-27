using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private Vector2 velocidade;
    public float aceleracao = 4f;

    void Start()
    {
		int spawn = UnityEngine.Random.Range(1, 5);
		switch (spawn)
		{
			case 1:
				velocidade.x = aceleracao;
				velocidade.y = aceleracao;
				break;
			case 2:
				velocidade.x = -aceleracao;
				velocidade.y = aceleracao;
				break;
			case 3:
				velocidade.x = -aceleracao;
				velocidade.y = -aceleracao;
				break;
			case 4:
				velocidade.x = aceleracao;
				velocidade.y = -aceleracao;
				break;
		}
		rb2d.velocity = velocidade;

    }

    
    void Update()
    {
        
    }
}
