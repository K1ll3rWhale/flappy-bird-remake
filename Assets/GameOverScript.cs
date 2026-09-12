using Unity.VisualScripting;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public LogicScript logic;

    public void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Player"))
        {
            logic.GameOver();

        }
    }




}
