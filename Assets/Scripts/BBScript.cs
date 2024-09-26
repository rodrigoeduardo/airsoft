using UnityEngine;

public class BBScript : MonoBehaviour
{
    public float backspinMagnitude = 10f;
    public float magnusCoefficient = 0.000001f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.angularVelocity = Vector3.right * backspinMagnitude;
    }

    void FixedUpdate()
    {
        print("Velocidade: " + rb.velocity);
        // ApplyHopUp();
    }

    void ApplyHopUp()
    {
        Vector3 velocity = rb.velocity;
        Vector3 angVelocity = rb.angularVelocity;

        rb.AddForce(magnusCoefficient * Vector3.Cross(angVelocity, velocity));
    }
}