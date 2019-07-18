using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void defense(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void magic()
    {
        if (mp >= 5)
        {
             mp -= 5;

            Debug.Log("魔法攻撃を行った。残りMPは" + mp);

        }

        else if (mp < 5)
        {
            Debug.Log("魔法を使うことができない");
        }

        
    }
    
}
public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        boss lastboss = new boss();

        lastboss.Attack();
        lastboss.defense(3);

        for (int a = 0; a < 11; a++)
        {
            lastboss.magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
      
       
    }
}
