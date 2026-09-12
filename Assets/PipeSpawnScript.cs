using UnityEngine;

public class PipeSpawnScript : MonoBehaviour{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 0f;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    public void spawnPipe()
    {
        float randomY =transform.position.y + Random.Range(-heightOffset, heightOffset);
        float xPos = transform.position.x;
        Vector3 spawnPos = new Vector3 (xPos, randomY, 0);
        Instantiate(pipe, spawnPos, Quaternion.identity);
    }
}
