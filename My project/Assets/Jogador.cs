using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
 [SerializeField]
 private bool jogador1;
 [SerializeField]
 private bool CorDoJogador;

    private void Start()
    {
        if (jogador1 != false) 
        {
         jogador1 = GetComponent<Rigidbody2D>();
         jogador1.Velocity = new Vector3(1, 1);

        }
     
    }




}
