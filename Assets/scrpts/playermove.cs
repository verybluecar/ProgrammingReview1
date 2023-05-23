using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float moveSpeed;
    public float playerLives;
    public Sprite deadRabbit;
    SpriteRenderer spriterender;
    // Start is called before the first frame update
    void Start()
    {
        spriterender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed);
        transform.Translate(Vector2.up * Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            moveSpeed = 0f;
            spriterender.sprite = deadRabbit;
            playerLives--;
            


        }
    }
}
