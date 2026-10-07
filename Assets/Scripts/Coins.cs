using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static int coinsCollected;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        coinsCollected++;
        if (coinsCollected == 3)
        {
            Debug.Log("You Win!");
        }
        GameObject.Destroy(gameObject);
    }
}
