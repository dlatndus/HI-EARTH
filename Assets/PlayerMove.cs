using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jump;
    public int speed = 10; //���ǵ� 
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x������ �̵��� ��
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime; //y������ �̵��Ҿ�
        this.transform.Translate(new Vector3(xMove, yMove, 0));  //�̵�

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
        }
    }
}