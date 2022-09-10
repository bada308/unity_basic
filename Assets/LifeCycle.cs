using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    /*
    1. 초기화
    1.5 활성화
    2. 물리 연산
    3. 게임 로직
    3.5 비활성화
    4. 해체
    */
    // Awake() : 게임 오브젝트 생성할 때 최소 실행
    void Awake() {
        Debug.Log("플레이어 데이터가 준비되었습니다.");    
    }

    void OnEnable() {
        Debug.Log("플레이어가 로그인 했습니다.");
    }

    // Start() : 업데이트 시작 직전, 최초 실행
    void Start() {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // FixedUpdate() : 물리 연산 업데이트 -> cpu 부화 많음
    void FixedUpdate() {
        Debug.Log("이동~~");
    }

    // Update() : 게임 로직 업데이트 (물리 연산 제외)
    void Update() {
        Debug.Log("몬스터 사냥~");
    }

    // LateUpadte() : 모든 업데이트 끝난 후 마지막으로 호출되는 함수
    void LateUpdate() {
        Debug.Log("경험치 획득.");
    }

    void OnDisable() {
        Debug.Log("플레이어가 로그아웃했습니다.");    
    }

    // OnDestroy() : 게임 오브젝트가 삭제될 때
    void OnDestroy() {
        Debug.Log("플레이어 데이터를 해제하였습니다.");  
    }


}
