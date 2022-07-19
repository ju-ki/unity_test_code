using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace Tests
{
    public class EditorModeTest2
    {
        [Test]
        public void SimpleFetchGameObjectName()
        {
            //あるゲームオブジェクトをとってきてその名前がフルーツではないテストコードを書け
            var gameObject = new GameObject();
            gameObject.name = "Dorcus titanus";
            Assert.AreNotEqual(gameObject.name, "フルーツ");
        }
        [Test]
        public void SimpleTotalAmountOfPurchase()
        {
            //[1]買い物の合計金額がAさんは100円の桃を2個と200円のぶどうを3個買いました
            //その合計金額が800円であるかというテストコードを書きなさい
            //金額->Amount
            //[2]消費税(30%)を含めた金額が1000円ではないテストコードを書きなさい
            //[3]買い物リストを定義してその中にパイナップルが含まれていないテストコードを書きなさい

            //[1]
            int peachRate = 100;
            int grapeRate = 200;
            int peachAm = 2;
            int grapeAm = 3;
            int totalAm =800;
            // AreEqual

            Assert.AreEqual(800,100 * 2 + 200 * 3);
            //[2]
            Assert.AreNotEqual(1000,1000 * 1.3);
            //[3]
            CollectionAssert.DoesNotContain(
                new List<string>(){"ゼリー","ケース","皿"}, "パイナップル");
        }
        
        [Test]
        public void BusyouGameObject()
        {
            //明智光秀、徳川家康、豊臣秀吉、織田信長、竹中半兵衛の武将リストを作成して、取得したゲームオブジェクトの名前に織田信長が含まれているテストコードを書く
            CollectionAssert.Contains(
                new List<string>(){"明智光秀","徳川家康","豊臣秀吉","織田信長","竹中半兵衛"}, "織田信長");
        }
    }
}
