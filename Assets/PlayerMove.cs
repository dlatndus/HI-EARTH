using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jump;
    public int speed = 5; //���ǵ� 
    private float horizontal;
    private Animator animator;
    private Rigidbody2D Rigidbody;
    private SpriteRenderer renderer;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        PlayerMoveOnKey();

        
        
    }



    private void PlayerMoveOnKey()
    {
        animator.SetFloat("speed", Mathf.Abs(horizontal));

        //����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
        }

        if (horizontal < 0)
        {
            renderer.flipX = true;
        }
        else
        {
            renderer.flipX = false;
        }
        Rigidbody.velocity = new Vector2(horizontal * speed, Rigidbody.velocity.y);

        /*
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x������ �̵��� ��
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime; //y������ �̵��Ҿ�
        this.transform.Translate(new Vector3(xMove, yMove, 0));  //�̵�
        

        if(horisontal)
        */
    }
}