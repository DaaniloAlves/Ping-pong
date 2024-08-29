using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
	public Rigidbody2D rb2d;
	private Vector2 velocidade;
	public float aceleracao = 6f;
	public AudioClip meuAudio;
	public Transform minhaCamera;
	private bool jogoIniciado = false;
	private float delay = 2f;

	void Start()
	{
		

	}


	void Update()
	{
		// jogo só é iniciado quando o tempo do delay passar
		delay = delay - Time.deltaTime;
		if (delay <= 0 && !jogoIniciado)
		{
			iniciarJogo();
		}


	}

	void iniciarJogo()
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
		jogoIniciado = true;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		AudioSource.PlayClipAtPoint(meuAudio, minhaCamera.position);
	}

}