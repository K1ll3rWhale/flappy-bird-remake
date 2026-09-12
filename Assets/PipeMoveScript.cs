using UnityEngine;
using UnityEngine.Rendering;

public class PipeMoveScript : MonoBehaviour{
    public float moveSpeed = 5f;
    public float deadZone = -5f;

    private void Update(){
        transform.position += (Vector3)Vector2.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }
}
