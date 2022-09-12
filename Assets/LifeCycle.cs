using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    
    void Update() {
        
        // 1. MoveTowards
        /*
        transform.position = Vector3.MoveTowards(transform.position, target, 2f);*/



        // 2.SmoothDamp
        /*
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        */

        // 3. Lerp (선형 보간)
        /*
        transform.position = Vector3.Lerp(transform.position, target, 0.1f);
        */

        // 4. Slerp (구면 선형 보간)
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }

    

}




/**
MoveTowards(현재위치, 목표위치, 속도) 
SmoothDamp(현재위치, 목표위치, 참조 속도, 속도)
Lerp: 선형 보간, SmoothDamp보다 감속시간이 김
Slerp: 구면 선형 보간, 호를 그리며 이동
*/