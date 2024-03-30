using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.forward * (Time.deltaTime * _speed);
        //transform.position += new Vector3(0.0f, 0.0f, 1.0f) * (Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * (Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * (Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * (Time.deltaTime * _speed);
        
    }
}
