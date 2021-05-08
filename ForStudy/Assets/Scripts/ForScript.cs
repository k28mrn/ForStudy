using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForScript : MonoBehaviour
{
    void Start()
    {
        //Kadai1();
        //Kadai2();
        //Kadai3();
        //Kadai4();
        //Kadai5();
        //Kadai6();
        //Kadai7();
        //TypeConf();
    }

    void Update()
    {
        
    }

    /// <summary>
    /// 課題1
    /// </summary>
    void Kadai1()
    {
        //i++ / i+=1 / i=i+1 すべて同様
        for (int i = 0; i < 10; i = i + 1)
        {
            Debug.Log(i);
        }
    }

    /// <summary>
    /// 課題2
    /// </summary>
    void Kadai2()
    {
        for (int i = 20; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }

    /// <summary>
    /// 課題3
    /// </summary>
    void Kadai3()
    {
        for (int i = 0; i <= 100; i+=2)
        {
            Debug.Log(i);
        }
    }

    /// <summary>
    /// 課題4
    /// </summary>
    void Kadai4()
    {
        int sum = 0;
        for (int i  = 1; i <= 100; i++)
        {
            sum = sum + i;
            //1回目 : 0 + 1 = 1
            //2回目 : 1 + 1 = 2
            //3回目 : 2 + 1 = 3
        }
        Debug.Log(sum);
    }

    /// <summary>
    /// 課題5
    /// </summary>
    void Kadai5()
    {
        int result = 1;
        for (int i = 0; i < 10; i++)
        {
            result = result * 2;
            //1回目 : 1 * 2 = 2
            //2回目 : 2 * 2 = 4
            //3回目 : 4 * 2 = 8
        }
        Debug.Log(result);
    }

    /// <summary>
    /// 課題6
    /// </summary>
    void Kadai6()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum = sum + i;
        }

        int average = sum / 100;

        Debug.Log(average);
    }

    /// <summary>
    /// 課題7
    /// </summary>
    void Kadai7()
    {
        float sum = 0;
        for (int i = 0; i <= 98; i++)
        {
            sum = sum + i;
        }

        float average = sum / 98;
        Debug.Log(average);
    }

    /// <summary>
    /// 【備考】型確認
    /// </summary>
    void TypeConf()
    {
        int a = 10;
        float b = 12.5f;
        string c = "555";
        string d = "文字連結";

        //a = a * (int)b;
        //Debug.Log(a);
        b = a * b;
        c = c + a; // "555" + "10"
        Debug.Log(c); // 55510
        d = c + d;
        Debug.Log(d); // 55510文字連結
    }
}
