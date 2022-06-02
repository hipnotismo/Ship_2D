using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject planet;
    [SerializeField]
    private float force;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 absorbVector = (planet.transform.position - player.transform.position).normalized;
        player.transform.position += absorbVector * Time.deltaTime * force;
    }
}
