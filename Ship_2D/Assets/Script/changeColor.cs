using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    [SerializeField] private Renderer body;
    public void change()
    {
        body.material.color = new Color(169, 21, 21);
        Debug.Log("yeah");
    }
}
