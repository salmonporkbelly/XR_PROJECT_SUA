using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + " 데미지를 입혔다.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " 데미지를 입었다.");
    }
}

public class Test_Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player mPlayer = new Player();
        mPlayer.Attack();
        mPlayer.Damage(30);

        Vector2 startPos = new Vector2(2.0f, 1.0f); //방향성 벡터
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos; // 두 벡터를 빼면 방향성을 알 수 있다
        Debug.Log(dir);
        
        float len = dir.magnitude; //백터의 길이를 구하는 멤버 변수
        Debug.Log(len);

    }
}
