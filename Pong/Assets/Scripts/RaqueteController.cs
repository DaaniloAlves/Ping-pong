using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    //Criando meu vector 3
    private Vector3 minhaPosicao;
    public float meuY;
    public float velocidade = 6.5f;
    public float limiteTela = 3.3f;


    void Start()
    {
        // pego a posicao inicial da raquete e aplico no meu jogo
        minhaPosicao = transform.position;
    }

    void Update()
    {
        Movimentar();
        // atualizando a posicao de Y
        minhaPosicao.y = meuY;
        // atualizando a posicao inteira da raquete
        transform.position = minhaPosicao;

    }

    void Movimentar()
    {
        if (Input.GetKey(KeyCode.W) && meuY < limiteTela)
        {
                meuY = meuY + velocidade * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) && meuY > -limiteTela)
        {
                meuY = meuY - velocidade * Time.deltaTime;
        } 
        
    }

}
