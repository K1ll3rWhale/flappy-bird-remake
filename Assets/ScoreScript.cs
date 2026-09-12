using Unity.VisualScripting;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public LogicScript logic;
   
    public void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        
       
        if (collision.gameObject.CompareTag("Player"))
        {
            logic.AddScore();
            
        }
    }
    
        
    

}
