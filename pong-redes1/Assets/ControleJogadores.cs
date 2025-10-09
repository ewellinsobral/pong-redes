using System;
using UnityEngine;

public class ControleJogadores : MonoBehaviour
{
    public float velocidadeDoJogador;

    public bool Jogador1;

    public float yMinimo;

    public float yMaximo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        if (Jogador1 == true)
        {
            MoverJogador1();
        }
        else
        {
            MoverJogador2();
        }
    }

    private void MoverJogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }

    private void MoverJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
}
