using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class ExampleBehaviourTest2 : ExampleBehaviour,IMonoBehaviourTest{
    public bool IsTestFinished{get;private set;}
    
    //Update is called nce per frame
    new void Update() {
      base.Update();
      Debug.Log(counter);
      if(counter > 10)
      {
        //ここで止めておかないと他のテストの裏でも動き続ける
        gameObject.SetActive(false);
        IsTestFinished = true;
      } 
    } 
}
