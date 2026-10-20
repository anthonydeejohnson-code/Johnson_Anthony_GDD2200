using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
        
        
    }

    public GameObject onCollectEffect;

    private void OnTriggerEnter(Collider other)
    {
        
        
        Destroy(gameObject);
        
        Instantiate( onCollectEffect , transform.position , transform.rotation);
    }
}