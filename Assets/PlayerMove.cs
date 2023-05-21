using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{

    public float jump = 10f; 
    public float jump2 = 12f; 
    private bool isSlide = false;


    private GameObject block;

    public Animator anim;



    int jumpCount = 0;

    void Start()
    {
        block = GameObject.FindGameObjectWithTag("Block");
        anim.SetBool("doubleJump", false);
    }

    void Update()
    {

    }

    public void Jump_Btn()
    {

        if (jumpCount == 0)  
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
            jumpCount += 1;  
        }
        else if (jumpCount == 1) 
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
            jumpCount += 1;  
            anim.SetBool("doubleJump", true);
        }

    }

    public void Slide_Btn()
    {



        if (isSlide == true)
        {


        }
        else if (isSlide == false)
        {


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            anim.SetBool("doubleJump", false);
            jumpCount = 0;


        }

        if (collision.gameObject.tag.CompareTo("Jump") == 0)
        {
            DataManager.Instance.playTimeCurrent -= 1f;
        }
        if (collision.gameObject.tag.CompareTo("Slide") == 0)
        {
            if (isSlide == true)
            {

            }
            else { DataManager.Instance.playTimeCurrent -= 1f; }

        }
    }


    public void OnPointerDown()
    {
        isSlide = true;
        anim.SetBool("isSlide", true);

    }

    public void OnPointerUp()
    {
        isSlide = false;
        anim.SetBool("isSlide", false);

    }
}

