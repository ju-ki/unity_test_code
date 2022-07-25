using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;//NunitではなくてUnityのAssertの方が良い(NunitはAreApproximatelyEqualがない)

namespace Tests
{
    [Author("Jukiya")]
    public class NewEditModeTest
    {
        [OneTimeSetUp]//最初のテストが実行される前に一回だけ出力される
        public void OneTimeSetUp()
        {
            Debug.LogWarning("OnetimeSetUp");
        }

        [SetUp]//テストが実行される前に毎回出力される
        public void SetUp()
        {
            Debug.Log("SetUp");
        }



        private bool isFight = false;
        // A Test behaves as an ordinary method
        [Test]
        public void NewEditModeTestSimplePasses()
        {
            // ref:https://docs.unity3d.com/ja/current/ScriptReference/Assertions.Assert.html
            Assert.AreEqual(2, 1 + 1);//a,bが同じであるかのテスト(Assert.AreEqual(a, b) (a=b))
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
            if (gameObject.name != "フルーツ")
            {
                Debug.Log("フルーツじゃないよ");
            }
            else
            {
                Debug.Log("フルーツだよ");
            }
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
            // bool isContainBananaFlag = false;
            // if(purchaseList.Contains("バナナ"))
            // {
            //     isContainBananaFlag = true;
            // }
            // else
            // {
            //     isContainBananaFlag = false;
            // }
            // Assert.IsFalse(isContainBananaFlag);
            CollectionAssert.Contains(purchaseList, "ミカン");
            CollectionAssert.AllItemsAreUnique(purchaseList);
            // for (int i=0; i < purchaseList.Count; i++)
            // {
            //     Assert.AreNotEqual("バナナ", purchaseList[i]);
            //     Assert.AreNotEqual("メロン", purchaseList[i]);
            // }
            // Assert.AreNotEqual("バナナ", purchaseList);
        }
        //テスト実行後に毎回出力
        [TearDown]
        public void TearDown()
        {
            Debug.Log("TearDown");
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
        [Description("絶対値を返すテスト")]
        // [Ignore("絶対値のテストはバグがあるので無視musi")]
        [Category("数学系")]
        [TestCase(1, -1)]
        [TestCase(2, -2)]
        [TestCase(3, -3)]
        // [TestCase(-10, 100)]
        // [Retry(3)]
        public void AbsTest(int expected, int input)
        {
            Assert.AreEqual(expected, Mathf.Abs(input));
        }
        [Test, Pairwise]
        //Valueで直接引数を選択できる
        //結果一覧->a + y, a - x, b - y, b + x, c - x, c + y
        public void ValidateLandingSiteOfRover_When_GoingToMars
        ([Values("a", "b", "c")] string a, [Values("+", "-")] string b, [Values("x", "y")] string c)
        {
            // Debug.WriteLine("{0} {1} {2}", a, b, c);
        }
        [OneTimeTearDown]//クラス内の最後のテストが実行された後に一回だけ出力される
        public void OneTimeTearDown()
        {
            Debug.LogWarning("OnetimeTearDown");
        }
    }
}
