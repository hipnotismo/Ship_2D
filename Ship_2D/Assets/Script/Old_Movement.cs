using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Old_Movement : MonoBehaviour
{
    [SerializeField] private Transform body;
    [SerializeField] private float speed;
    SpriteRenderer rend;
    Vector2 movement;

    public float runSpeed = 10.0f;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
    
    }
    
    void Update()
    {
        float i = Input.GetAxisRaw("Horizontal");
        float j = Input.GetAxisRaw("Vertical");

        Vector3 maxPosWorld = rend.bounds.max;
        Vector3 maxPosViweport = Camera.main.WorldToScreenPoint(maxPosWorld);

        Vector3 sizeXWorld = Camera.main.WorldToScreenPoint(rend.bounds.size);
        sizeXWorld.x /= sizeXWorld.z;
        sizeXWorld.y /= sizeXWorld.z;

        if (maxPosViweport.y > Screen.height)
        {
            Debug.Log("Y " + maxPosViweport.y);
        }

        if (maxPosViweport.y - sizeXWorld.y < 0)
        {
            Debug.Log("Y less than 0" + maxPosViweport.y);
        }

        if (maxPosViweport.x > Screen.width)
        {
            Debug.Log("X " + maxPosViweport.x);
        }

        if (maxPosViweport.x - sizeXWorld.x < 0 )
        {
            Debug.Log("X less than 0 " + maxPosViweport.x);
          //  body.position = new Vector3(Screen.width - Screen.width, transform.position.y);
        }

        body.Translate(i * Time.deltaTime * speed, j * Time.deltaTime * speed,0);
    }   
}
