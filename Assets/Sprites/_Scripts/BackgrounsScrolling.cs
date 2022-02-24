using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrounsScrolling : MonoBehaviour
{
    public MeshRenderer mr;
    float speed = 1.0f;

    
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(0 , speed* Time.deltaTime);
        
    }
}
