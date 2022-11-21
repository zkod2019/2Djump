using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // adding this namespace to start using scene management and changing scenes
using UnityEngine;
using UnityEngine.UI;
using System.Text;
 
public class FinishLine : MonoBehaviour
{
    public Text levelText;
    public static int levelCount = 1;
    private string test;
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
            
            levelText=GameObject.Find("LevelCount").GetComponent<Text>(); 
            Debug.Log(levelText);

           // levelText.text = levelCount.ToString();
            //levelCount = (int)((JObject)fields.GetValue("level")).GetValue("integerValue");

            //numericalScore.GetComponent<Text>().text = "Score : " + scoreManager.score; 
            levelCount = levelCount + 1;
            levelText.text =  "Loop: " + levelCount.ToString();
            

            Debug.Log("Timer initialized!!");
            Debug.Log(levelCount);
            
        }
    }
}
 
