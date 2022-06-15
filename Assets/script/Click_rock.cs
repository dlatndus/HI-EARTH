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
        }
    }

    private void OnMouseDown()
    {
        cnt++;
    }
}