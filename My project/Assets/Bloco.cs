using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    private bool Conquistado;
    private SpriteRenderer spriteRenderer;
    private int Conquistou;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Color Bloco = Color.white;
    }
    //public void AlterarConquista(bool jogador1, Color CorDoJogador)
    //{if
   //     Conquistado = true;
    //    Color Bloco = CorDoJogador;




   // }
}
