using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirst : MonoBehaviour
{
    string title = "전설의";
    string playerName = "나검사";
    int level = 5;
    int health = 30;
    int mana = 25;
    float strength = 15.5f;
    bool isFullLevel = false;
    int exp = 1500;

    void Start()
    {

        // 1. 변수
        
        


        // 2. 그룹형 변수

        string[] monsters = {"슬라임", "사막뱀", "악마"};   // 배열
        int[] monterLevel = new int[3];

        monterLevel[0] = 1;
        monterLevel[1] = 6;
        monterLevel[2] = 20;

        List<string> items = new List<string>();

        items.Add("생명물약30");
        items.Add("마나물약30");

        items.RemoveAt(0);

        // 3. 연산자

        

        exp = 1500 + 320;
        exp -= 10;
        level = exp / 300;
        strength = level * 3.1f; 

        int nextExp = 300 - (exp % 300);

        

        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level > 10;

        
        

        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";

        // 4. 키워드
        // int float string bool new List etc...

        // 5. 조건문

        if(condition == "나쁨"){
            
        }else{
            
        }
    
        switch (monsters[0]){
            case "슬라임":
            case "사막뱀":
                break;
            case "악마":
                break;
            case "골렘":
                break;
            default:
                break;
        }

        // 6. 반복문

        while(health > 0){
            health--;
            if(health > 0){
                
            }else{

            }

            if(health == 10){

                break;
            }
            
        }

        for(int count = 0; count < 10; count++){
            health++;
            
        }

        for(int index = 0; index < monsters.Length; index++){
            //Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        // 처음보는 foreach..

        foreach(string monster in monsters){
            //Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }

        Heal();

        for(int index = 0; index < monsters.Length; index++){
            //Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monterLevel[index]));
        }

        // 8. 클래스
        Player player = new Player();     // 인스턴스화
        player.id = 0;
        player.name = "나법사";
        player.title ="현명한";
        player.weapon = "나무 지팡이";
        player.strength = 2.4f;

        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨: " + player.level);

        Debug.Log(player.move());

    }
    
    // 7. 함수 (메소드)
    void Heal(){
        health += 10;
    }

    string Battle(int monsterLevel){
        string result;

        if(level >= monsterLevel){
            result = "이겼습니다";
        }else{
            result = "졌습니다";
        }

        return result;
    }
}
