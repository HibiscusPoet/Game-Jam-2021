using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5;
    [SerializeField]
    float jump = 0.5f;

    public DialogueTrigger dialogueTrigger;
    public GameObject dialogueRelated;

    private float movement;

    Rigidbody2D rigidbody2d;
    Vector3 savePoint = new Vector3(-5f, -2.5f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody2d.velocity.y) < 0.01f)
        {
            rigidbody2d.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

        movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            transform.position = savePoint;
        }

        if (collision.gameObject.tag == "Savepoint")
        {
            savePoint = collision.gameObject.transform.position;
        }

        if (collision.gameObject.tag == "Castle")
        {
            dialogueRelated.SetActive(true);
            dialogueTrigger.TriggerDialogue();
        }
    }
}
