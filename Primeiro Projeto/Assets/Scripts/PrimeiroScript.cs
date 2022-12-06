using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{
    public float position;
    // Start is called before the first frame update
    void Start()
    {
        position = PlayerPrefs.GetFloat("POSICAO", 1);

        //incrementa 1 na variável
        position++; //position = position + 1;

        //usaria apra salvar por exemplo, um rank do jogador, quando ele chegar mais longe salva o que for mais longe
        PlayerPrefs.SetFloat("POSICAO", position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
