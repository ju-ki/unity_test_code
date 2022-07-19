using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class ExampleBehaviourTest : ExampleBehaviour, IMonoBehaviourTest {
    public bool IsTestFinished { get; private set; }

    // Update is called once per frame
    new void Update () {
        base.Update();
        Debug.Log(counter);
        if (counter > 10)
        {
            gameObject.SetActive(false);
            IsTestFinished = true;
        }
    }
}