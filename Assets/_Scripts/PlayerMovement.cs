using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xmov,speed, jumpheight;
    public Animator anim;
    public Rigidbody rgbd;
    public bool isBack;
    public float x = 10.0f, y =10.0f, z =10.0f;
   
    
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("IsRunning", false);
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        xmov = this.transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IsRunning", true);
            this.transform.position = new Vector3(xmov, this.transform.position.y, this.transform.position.z);
            isBack = false;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(xmov, this.transform.position.y, this.transform.position.z);
            isBack = true;
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
        if (isBack && Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(x*-1, y, z);
        }
        else 
        {
            transform.localScale = new Vector3(x, y, z);
        }
        

    }
}
    