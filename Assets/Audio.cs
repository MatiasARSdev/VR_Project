using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTrigger2 : MonoBehaviour
{
    public AudioSource sonido;
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
         sonido.Play();
        
        
    }
}