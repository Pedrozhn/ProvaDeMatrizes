using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Jogador : MonoBehaviour
{
 [SerializeField]
 private bool jogador1;
 [SerializeField]
 private bool CorDoJogador;
    public int Velocidade = 1;

    private void Start()
    {
        if (jogador1 == true) 
        {
         jogador1 = Velocidade == 1;
            Color Jogador1 = Color.red; 
        }
        else
        {
            jogador1 = false;
        }
        
        
     
    }

    private Vector2 Direcao;

    private void Update()
    {
        if (jogador1) 
        {
            Input.GetKeyDown(KeyCode.A);

            Input.GetKeyDown(KeyCode.W);

            Input.GetKeyDown(KeyCode.S);

            Input.GetKeyDown(KeyCode.D);

        }
        
    }


}
