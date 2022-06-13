using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Transform player;
    public float Speed;
    bool left, right;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            player.position += Vector3.right * Speed * Time.deltaTime;
        }
        if (left)
        {
            player.position += Vector3.left * Speed * Time.deltaTime;
        }
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
