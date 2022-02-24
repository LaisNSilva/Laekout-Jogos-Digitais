using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Invoke("Destruir", 0.2f);
    }
    void Destruir(){
        Destroy(gameObject);
    }

    
}
