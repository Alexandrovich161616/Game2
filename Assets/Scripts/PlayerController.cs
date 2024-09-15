using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private Vector3 direction;
    public float jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        direction = new Vector3(inputX * speed, rb.linearVelocity.y, inputZ * speed);
        direction = transform.TransformDirection(direction);

        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = direction;
        
    }
}
