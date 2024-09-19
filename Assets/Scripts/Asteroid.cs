using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid : MonoBehaviour
{
    float speed;
    public float topSpeed, bottomSpeed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = Random.Range(bottomSpeed, topSpeed);

        Vector3 rot;
        rot.x = Random.Range(-20, 20);
        rot.y = Random.Range(-20, 20);
        rot.z = Random.Range(-20, 20);
        rb.AddTorque(rot);

        transform.localScale = Vector3.one * Random.Range(1f,3f);
        rb.AddForce(Vector3.back * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "asteroid")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame

}
