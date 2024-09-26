using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBB : MonoBehaviour
{
    public Transform bbTransform;
    public GameObject bbPrefab;

    public float bbMass= 0.0002f;

    public float energy = 1.49f;

    public float velocity = 0;

    public float fps = 0;

    float feetInMeters = 3.28084f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            velocity = Mathf.Sqrt(2 * energy / bbMass);

            GameObject bb = Instantiate(bbPrefab, bbTransform.position, bbTransform.rotation);
            Rigidbody rb = bb.GetComponent<Rigidbody>();
            rb.mass = bbMass;
            rb.velocity = bbTransform.forward * velocity;
            fps = velocity * feetInMeters;
            print("FPS: " + fps);

            Destroy(bb, 5f);
        }
    }
}
