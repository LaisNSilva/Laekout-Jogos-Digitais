using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    
    GameManager gm;

    

    public GameObject e;
 
    private void OnTriggerEnter2D(Collider2D collision){
        gm = GameManager.GetInstance();

        if(gameObject.GetComponent<SpriteRenderer>().color == Color.green){
            gm.pontos= gm.pontos + 2;
        }
        else{
            gm.pontos++;
        }
        
        if(gameObject.GetComponent<SpriteRenderer>().color == Color.red)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else{
            
            Instantiate(e, transform.position, transform.rotation);
            Destroy(gameObject);
           
        }
        

        
        
    }
}
