using UnityEngine;

public class car : MonoBehaviour
{

    public Rigidbody2D rb;

    float delay = 2.5f;
    public float speed = 1f;

    SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    void ChangeSprite()
    {
        if (speed < 9.0f)
        {
            spriteRenderer.sprite = spriteArray[0];
        }

        else if (speed >= 9.0f && speed < 10.0f)
        {
            spriteRenderer.sprite = spriteArray[1];
        }

        else if (speed >= 10.0f && speed < 11.0f)
        {
            spriteRenderer.sprite = spriteArray[2];
        }

        else if (speed >= 11.0f)
        {
            spriteRenderer.sprite = spriteArray[3];
        }

    }


    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        speed = Random.Range(ChangeSpeed.minSpd, ChangeSpeed.maxSpd);
        ChangeSprite();
    }


    void FixedUpdate()
    {

        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        Destroy(gameObject, delay);

    }
}
