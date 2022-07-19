using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;
namespace Tests
{
    //refs: https://developer.aiming-inc.com/unity/unity-playmode-test-runner/
    public class NewTestPlayModeScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestPlayModeScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestPlayModeScriptWithEnumeratorPasses()
        {
            var startTime = Time.time;
            //一秒間（1000ミリ秒）停止する
            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual(startTime, Time.time);
            yield return new WaitForSeconds(1f);

            Assert.AreNotEqual(startTime, Time.time);
            yield return null;
        }
        [UnityTest]
        public IEnumerator BehaviourTest()
        {
            yield return new MonoBehaviourTest<ExampleBehaviourTest>();
        }
    }
}
