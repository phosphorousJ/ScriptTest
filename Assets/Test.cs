using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    public int mp = 53;        //MP用

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic() 
    {

        //魔法攻撃を10回繰り返す
        for(int i = 1; i <= 10; i++) 
        {
            if (mp >= 5) 
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りのMPは" + mp + ".");
            }
        }

        Debug.Log("MPが足りないため魔法が使えない。");
    }
}


public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);

        //魔法攻撃用の関数を呼び出す
        lastboss.Magic();


        Boss midboss = new Boss();
        midboss.Attack();
        midboss.Defence(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
