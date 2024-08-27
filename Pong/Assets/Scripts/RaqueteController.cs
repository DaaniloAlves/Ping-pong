using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    //Criando meu vector 3
    private Vector3 minhaPosicao;

    private float meuY;
    public float velocidade = 6.5f;
    private float limiteTela = 3.3f;
    public bool automatico;
    public Transform bolaTransform;
    public bool player1;


    void Start()
    {
        // pego a posicao inicial da raquete e aplico no meu jogo
        minhaPosicao = transform.position;
    }

    void Update()
    {
        MovimentarRaquete();
    }

    void MovimentarRaquete()
    {
        float deltaVelocidade = velocidade * Time.deltaTime;

        if (!player1 && !automatico)
        {
            if (Input.GetKey(KeyCode.UpArrow) && meuY < limiteTela)
            {
                meuY = meuY + deltaVelocidade;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && meuY > -limiteTela)
            {
                meuY = meuY - deltaVelocidade;
            }
            // atualizando a posicao de Y
            minhaPosicao.y = meuY;
            // atualizando a posicao inteira da raquete
            transform.position = minhaPosicao;
        }
        else if (!automatico)
        {
            if (Input.GetKey(KeyCode.W) && meuY < limiteTela)
            {
                meuY = meuY + deltaVelocidade;
            }
            else if (Input.GetKey(KeyCode.S) && meuY > -limiteTela)
            {
                meuY = meuY - deltaVelocidade;
            }
            // atualizando a posicao de Y
            minhaPosicao.y = meuY;
            // atualizando a posicao inteira da raquete
            transform.position = minhaPosicao;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                automatico = false;
            }
            if (Input.GetKeyDown(KeyCode.F)) 
            {
                automatico = true;
            }
            // função que faz um valor ir até o outro gradativamente, sem ser brusco
            meuY = Mathf.Lerp(meuY, bolaTransform.position.y, 0.1f);
            if (meuY < limiteTela && meuY > -limiteTela)
            {
				minhaPosicao.y = meuY;
				transform.position = minhaPosicao;
			}
        }
    }
}
