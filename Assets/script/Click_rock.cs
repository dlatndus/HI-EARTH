using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_rock : MonoBehaviour
{
    int cnt = 0;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[0];

    }

    // Update is called once per frame
    void Update()
    {
        if (cnt > 0)
        {
            spriteRenderer.sprite = sprites[cnt];
            if (cnt==6)
            {
                gameObject.GetComponent<Rigidbody2D>().mass = 2;
                gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.9f, -1.3f);
                gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.6f, 2.2f);
            }
        }
    }

    private void OnMouseDown()
    {
        cnt++;
    }
}