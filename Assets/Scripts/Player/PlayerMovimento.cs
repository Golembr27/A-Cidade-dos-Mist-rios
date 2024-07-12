using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    
    float velocidade = 5f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movimentacao = new Vector3(horizontal, 0, 0) * velocidade * Time.deltaTime;

        transform.Translate(movimentacao);

    }
}
