using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlane : MonoBehaviour
{
    public bool tocou = false;
    public GameObject enemy;
    public Text text_obj;
    public AudioSource som_explosao;

    int pontos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector3(0,0.05f,0));
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(new Vector3(0,-0.05f,0));
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3(-0.05f,0,0));
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3(0.05f,0,0));
        }
    }
     void OnTriggerEnter2D(Collider2D body){
        
        if(body.gameObject.CompareTag("moeda")){
            som_explosao.Play();
            Destroy(body.gameObject);
            pontos++;
            text_obj.text = "Satélites: " + pontos;
        }
       

    }
    // void OnTriggerExit2D(Collider2D body){
    //     canPass = false;
    //     if(body.gameObject.CompareTag("plane")){
    //          Destroy(enemy.gameObject);
    //     }
    // }
}
