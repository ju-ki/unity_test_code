using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectMovement : MonoBehaviour
{
    //やりたいこと
    //ヒエラルキーにあるTestObjectという名前のゲームオブジェクトをとってきてNullじゃないテスト
    //testObject
    // public string _testObject;
    public static GameObjectMovement instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Debug.Log(instance);
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private GameObject _testObject;

    public void GameObjectMovement2(GameObject _testObject)
    {
        this._testObject = _testObject;
    }
}
