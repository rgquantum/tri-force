using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public Sprite front_Image;
    public Sprite back_Image;
    public Level card_Level;
    public bool face_up;



    void Start()
    {
        
    }


    void Update()
    {
        renderBack();
    }

    public void flip()
    {
        
    }

    public void renderBack()
    {
        if(face_up == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = back_Image;    
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = front_Image;
        }
        
    }

    void OnMouseDown()
    {
        if(face_up == true)
        {
            face_up = false;
        }
        else
        {
            face_up = true;
        }
    }
}
