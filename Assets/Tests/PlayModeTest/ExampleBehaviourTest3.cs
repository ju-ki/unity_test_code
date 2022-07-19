using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class ExampleBehaviourTest3 : ExampleBehaviour,IMonoBehaviourTest
{
    public bool IsTestFinished{get; private set;}
    
    // Start is called before the first frame update
    new void Update() //新しいvoid Update を定義
    {
        base.Update(); // 親クラスのUpdateを呼ぶ 
        Debug.Log(counter);//counterの呼び出し
        if (counter > 10) //もしcounterが10を超えたら
        {
            //ここで止めておかないとほかのテストの裏でも動き続ける
            gameObject.SetActive(false); //gameobject
            IsTestFinished = true;
        }
    }
}   
