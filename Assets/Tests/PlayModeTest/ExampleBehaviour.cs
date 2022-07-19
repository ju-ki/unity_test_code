using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviour : MonoBehaviour
{
    //その型とその派生型はアクセスできる
    //子クラスからはつかえる。継承する時つかう
    protected int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected void Update()
    {
        counter++;
    }
}
