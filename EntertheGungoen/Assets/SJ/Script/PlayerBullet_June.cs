using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet_June : MonoBehaviour
{


    void Start()
    {
       


    }
    void Update()
    {
      
    }




   
    
    
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
