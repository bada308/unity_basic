using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start() {

    }

    
    void Update() {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0
        );
        transform.Translate(vec);
        

    }

    

}

/**
    Time.deltaTime 사용하는 방법

    Translate: 벡터에 곱하기
    Vector 함수: 시간 매개변수에 곱하기
*/