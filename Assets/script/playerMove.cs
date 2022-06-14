using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Transform player;
    public float Speed;
    bool right,left;
    Animator animator;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        animator = player.GetComponent<Animator>();
        rigid = player.GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            player.position += Vector3.right * Speed * Time.deltaTime;
            player.transform.localScale = new Vector3(0.45f, 0.45f, 1f);
        }
        if (left)
        {
            player.position += Vector3.left * Speed * Time.deltaTime;
            player.transform.localScale = new Vector3(-0.45f, 0.45f, 1f);
        }
        if (Mathf.Abs(rigid.velocity.x) < 0.03) animator.SetBool("iswalk", false);
        else animator.SetBool("iswalk", true);
    }

    public void Up()
    {
        right = false;
    }
    public void Dawn()
    {
        right = true;
    }
    public void BackUp()
    {
        left = false;
    }
    public void BackDown()
    {
        left = true;
    }
}
