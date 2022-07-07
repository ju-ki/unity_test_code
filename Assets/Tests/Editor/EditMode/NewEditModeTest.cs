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

            //gameObjectに名前をつけてそれが指定した名前と同じであるかの確認
            var gameObject = new GameObject();
            gameObject.name = "test game object";
            Assert.AreEqual("test game object", gameObject.name);
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
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewEditModeTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
