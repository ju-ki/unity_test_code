﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace Tests
{
    public class PlayModeTest
    {
        GameObjectMovement gameMovement;
        GameObject testObject;
        [OneTimeSetUp]
        public void InitTest()
        {
            SceneManager.LoadSceneAsync("SampleScene").completed += _ => {
                Debug.Log("Scene Loaded");
                testObject = GameObject.Find("testObject");
            };
        }
        [UnityTest]
        public IEnumerator PlayModeGameObjectMovementPasses()
        {
            Assert.IsNotNull(testObject);
            yield return null;
        }
    }
}