using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // adding this namespace to start using scene management and changing scenes
using UnityEngine;
 
public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
 
    // Update is called once per frame
    void Update()
    {
       
    }
 
    public void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // .sceneCount + 1);
        }
    }
}
 
