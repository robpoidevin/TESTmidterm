using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed;
    public float jumpSpeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += Vector3.forward * moveSpeed;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += Vector3.back * moveSpeed;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position += Vector3.left * moveSpeed;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += Vector3.right * moveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
    }
}
