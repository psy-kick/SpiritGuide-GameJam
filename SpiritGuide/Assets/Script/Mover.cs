using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour, IPickable
{
    public float speed = 5f;
    private Rigidbody2D rb;

    public void Pickup()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //TODO: Pickup
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(Horizontal, Vertical)*speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pickable")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
