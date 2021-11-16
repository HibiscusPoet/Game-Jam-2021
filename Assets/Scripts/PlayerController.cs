using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5;
    [SerializeField]
    float jump = 0.5f;

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2d.AddForce(new Vector2(speed, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.AddForce(new Vector2(0, jump));
        }
    }
}
