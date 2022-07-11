using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;//NunitではなくてUnityのAssertの方が良い(NunitはAreApproximatelyEqualがない)

namespace Tests
{
    public class NewEditModeTest
    {
        private bool isFight = false;
        // A Test behaves as an ordinary method
        [Test]
        public void NewEditModeTestSimplePasses()
        {
            // ref:https://docs.unity3d.com/ja/current/ScriptReference/Assertions.Assert.html
            Assert.AreEqual(2, 1 + 1);//a,bが同じであるかのテスト
            // Assert.AreEqual(3, 1 + 1);//通らないはず
            Assert.AreNotEqual(3, 1 + 1);//a,bが同じではないかのテスト
            // Assert.IsTrue(isFight);//これも通らない
            Assert.IsFalse(isFight);//aがfalseであるかのテスト
            Assert.AreApproximatelyEqual(0.0000001f, 0.000000002f);//a==b(ほぼ同じ)であるかのテスト
            // Assert.AreApproximatelyEqual(1.0f, 1.5f);//これも通らない
            Assert.AreNotApproximatelyEqual(1.0f, 1.5f);//a==b(ほぼ同じ)でないかのテスト

            Assert.AreEqual(6, 3 + 3);
            Assert.AreNotEqual("jukiya", "zukiya");

            //gameObjectに名前をつけてそれが指定した名前と同じであるかの確認
            var gameObject = new GameObject();
            gameObject.name = "test game object";
            Assert.AreEqual("test game object", gameObject.name);
        }

        [Test]
        public void SimpleFetchGameObjectName()
        {
            //あるゲームオブジェクトをとってきてその名前がフルーツではないテストコードを書け
            var gameObject = new GameObject();
            gameObject.name = "object";
            Assert.AreNotEqual(gameObject.name, "フルーツ");
            // if (gameObject.name != "フルーツ")
            // {
            //     Debug.Log("フルーツじゃないよ");
            // }
            // else
            // {
            //     Debug.Log("フルーツだよ");
            // }
        }
        [Test]
        public void SimpleTotalAmountOfPurchase()
        {
            //[1]買い物の合計金額がAさんは100円のリンゴを2個と200円のオレンジを3個買いました
            //その合計金額が800円であるかというテストコードを書きなさい
            //金額->Amount
            //[2]消費税(10%)を含めた金額が1000円ではないテストコードを書きなさい
            //[3]買い物リストを定義してその中にバナナが含まれていないテストコードを書きなさい
            
            //[[1]
            int appleAmount = 100;
            int orangeAmount = 200;
            int sumOfApple = 2;
            int sumOfOrange = 3;
            int totalAmountOfPurchase = 800;
            Assert.AreEqual(100,appleAmount);
            Assert.AreEqual(200, orangeAmount);
            Assert.AreEqual(2,sumOfApple);
            Assert.AreEqual(3, sumOfOrange);
            Assert.AreEqual(totalAmountOfPurchase, appleAmount*sumOfApple + orangeAmount*sumOfOrange);
            // [2]
            float currentSalesTax = 1.10f;
            float amountIncludingConsumptionTax = totalAmountOfPurchase*currentSalesTax;
            Assert.AreNotEqual(1000, amountIncludingConsumptionTax);
            //[3]
            List<string> purchaseList = new List<string>(){"モモ","ミカン","ブドウ"};
            bool isContainBananaFlag = false;
            // if(purchaseList.Contains("バナナ"))
            // {
            //     isContainBananaFlag = true;
            // }
            // else
            // {
            //     isContainBananaFlag = false;
            // }
            // Assert.IsFalse(isContainBananaFlag);
            for (int i=0; i < purchaseList.Count; i++)
            {
                Assert.AreNotEqual("バナナ", purchaseList[i]);
                Assert.AreNotEqual("メロン", purchaseList[i]);
            }
            // Assert.AreNotEqual("バナナ", purchaseList);
        }
        [Test]
        public void SimpleCalculationPasses()
        {

            //簡単な数値計算のテスト(特に意味はない)
            int num1 = 1;
            int num2 = 2;
            Assert.AreNotEqual(num1, num2);
            Assert.AreEqual(3, num1 + num2);
            Debug.Assert(num1 + 1 == num2);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield r eturn null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewEditModeTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
