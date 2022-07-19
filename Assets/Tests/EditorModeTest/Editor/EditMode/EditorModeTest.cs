using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace Tests
{
    public class EditorModeTest
    {
        //Asahiさん用のテストコード
        [Test]
        public void EditorModeTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }
        [Test]
        public void BasicArithmeticOperations()
        {
            // var gameObject = new GameObject();
            // gameObject.name = "織田信長"
            // Assert.AreNotEqual(gameObject.name, "豊臣秀吉");
            // if (gameObject != 豊臣秀吉)
            // {
            //     Debug.Log("儂は秀吉ではないぞ！");
            // }else
            // {
            //     Debug.Log("儂が秀吉だぞ！");
            // }
        }
        [Test]
        public void BusyouGameObject()
        {
            //明智光秀、徳川家康、豊臣秀吉、織田信長、竹中半兵衛の武将リストを作成して、取得したゲームオブジェクトの名前に織田信長が含まれているテストコードを書く
            List<string> sengokuSamurai = new List<string>(){"明智光秀", "徳川家康", "豊臣秀吉", "織田信長", "竹中半兵衛"};
            CollectionAssert.Contains(sengokuSamurai, "織田信長");
        }
    }
}
