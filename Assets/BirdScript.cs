using UnityEngine;

public class BirdScript : MonoBehaviour{
    public Rigidbody2D Bird;
    public float flapStrength = 8f;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            Bird.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
