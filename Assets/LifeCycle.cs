using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Awake() : 게임 오브젝트 생성할 때 최소 실행
    void Awake() {
        Debug.Log("플레이어 데이터가 준비되었습니다.");    
    }

    // 
    void Start() {
        
    }
}
