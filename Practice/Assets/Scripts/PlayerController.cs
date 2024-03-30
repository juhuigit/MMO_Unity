using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MyVector
// : x, y, z 값으로 구성
// : 위치 벡터 or 방향 벡터
struct MyVector
{
    public float x;
    public float y;
    public float z;

    // 피타고라스 정리
    //          +
    //     +    +
    // +--------+
    public float magnitube { get { return Mathf.Sqrt(x * x + y * y + z * z); } }
    // normalized : 단위 벡터 (크기가 1인 벡터)
    //            : 방향의 크기는 무시한 채, 방향의 정보만 추출할 수 있음.
    public MyVector normalized { get { return new MyVector(x / magnitube, y / magnitube, z / magnitube); } }
    public MyVector(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }
    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    public static MyVector operator *(MyVector a, float d)
    {
        return new MyVector(a.x * d, a.y * d, a.z * d);
    }
    
}


public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    
    void Start()
    {
        MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from; // (5.0f, 0.0f, 0.0f)
        dir = dir.normalized; // (1.0f, 0.0f, 0.0f)
        
        MyVector newPos = from + dir * _speed; // from으로부터 원하는 방향으로 _speed만큼 이동
        // 방향 벡터
        // 1. 거리(크기) 
        // 2. 실제 방향
    }
    
    void Update()
    {
        // Local -> World
        // TransformDirection
        
        // World -> Local
        // InverseTransformDirection
        
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
