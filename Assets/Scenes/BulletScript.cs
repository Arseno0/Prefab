using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float BulletScriptSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += BulletScriptSpeed * transform.forward * Time.deltaTime;
    }
}
