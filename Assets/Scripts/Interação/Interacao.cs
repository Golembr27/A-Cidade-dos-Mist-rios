using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Colocar imagem
using UnityEngine.SceneManagement;// Entrar na cena
using Unity.VisualScripting;

public class Interacao : MonoBehaviour
{
    public int interagir = 0;
    public string NomeDaCena;
    public GameObject imgInteracao;

    void Start()
    {
        imgInteracao.SetActive(false);
    }


    void Update()
    {
        if (interagir == 1 && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("oi");
            SceneManager.LoadScene(NomeDaCena);
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        imgInteracao.SetActive(true);
        if(c.CompareTag("Player"))
        {
            interagir = 1;
        }
    }
    void OnTriggerExit2D(Collider2D c)
    {
        imgInteracao.SetActive(false);
        interagir = 0;
    }

}
