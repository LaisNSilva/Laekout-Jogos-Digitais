using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour
{

    public GameObject Bloco;
    GameManager gm;

    //Bloco tijolo;

    //public int qtd;

    Color[] cores = new Color[3] {Color.red, Color.blue, Color.green};
    

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        GameManager.changeStateDelegate += Construir;
        Construir();
        
    }

    void Construir(){
        if(gm.gameState == GameManager.GameState.GAME){
            foreach(Transform child in transform){
                GameObject.Destroy(child.gameObject);
                
            }
            for(int i=0; i<12; i++){
                for(int j=0; j<(4); j++){
                    //qtd = 12 * 4;
                    Vector3 posicao = new Vector3(-9 +1.55f * i, 4 - 0.55f * j);
                    Color c = cores[Random.Range(0, cores.Length)];
                    Bloco.GetComponent<SpriteRenderer>().color= c;
                    Instantiate(Bloco, posicao, Quaternion.identity, transform);
                }
           }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0 && gm.gameState == GameManager.GameState.GAME)
        {
            gm.changeState(GameManager.GameState.ENDGAME);
        }
    }
}
