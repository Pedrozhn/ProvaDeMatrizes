using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class GameManager : MonoBehaviour
{
    public GameObject jogador1;
    public GameObject jogador2;
    public int linha = 5;
    public int coluna = 5;
    public float espacamento = 1.1f;

    private int[] Bloco;
    private int[] Conquista;

    #region Singleton
    public static GameManager instance;


    private void Awake()
    {
        instance = this;
    }
    #endregion
    
    private void CriarGrade() 
    {
        for (int x = 0; x < linha; x++)
        {

            for (int y = 0; y < coluna; y++)
            {

               Vector3 position = new Vector3(x * espacamento, y * espacamento, 0);
                
               


            }



        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
