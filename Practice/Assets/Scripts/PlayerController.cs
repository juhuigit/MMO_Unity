using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    
    void Start()
    {
        
    }

    private float _yAngle = 0.0f;
    void Update()
    {
        _yAngle += Time.deltaTime * _speed;
        // 절대 회전값
        // transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);
        // +- delta
        // transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        //transform.rotation = Quaternion.Euler(0.0f, _yAngle, 0.0f);

        if (Input.GetKey(KeyCode.W))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward); // 키보드를 누르면 원하는 방향으로 바라보기
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f); // 스르륵 움직이기
            transform.position += Vector3.forward * (Time.deltaTime * _speed); // 키보드를 누르면 원하는 방향으로 움직이기
            //transform.position += new Vector3(0.0f, 0.0f, 1.0f) * (Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            transform.position += Vector3.back * (Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            //transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.position += Vector3.left * (Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            //transform.rotation = Quaternion.LookRotation(Vector3.right);
            transform.position += Vector3.right * (Time.deltaTime * _speed);
        }

    }
}
