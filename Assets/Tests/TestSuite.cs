﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        public GameObject level;
        public LevelBehaviour levelMovement;
        public PlayerMovement player;



        [SetUp]
        public void Setup()
        {
            level = Object.Instantiate(Resources.Load<GameObject>("Prefabs/levelPrefab"));
            levelMovement = level.GetComponent<LevelBehaviour>();
            player = levelMovement.player;
        }

        [TearDown]
        public void TearDown()
        {
            Object.Destroy(level.gameObject);
        }

        [UnityTest]
        public IEnumerator DoesThePlayerMoveOutOffBoundsWhilePressingLeftWhenAtLeftLane()
        {
            SetPlayerInMiddleLane();
            yield return new WaitForSecondsRealtime(1f);
            player.MoveLeft();
            yield return new WaitForSecondsRealtime(1f);
            Assert.AreEqual(0, player.playerPosition);
            player.MoveLeft();

            yield return null;
        }

        [UnityTest]
        public IEnumerator DoesThePlayerMoveOutOffBoundsWhilePressingRightWhenAtRightLane()
        {
            SetPlayerInMiddleLane();
            yield return new WaitForSecondsRealtime(1f);
            player.MoveRight();
            yield return new WaitForSecondsRealtime(1f);
            Assert.AreEqual(2, player.playerPosition);
            player.MoveRight();

            yield return null;
        }

        void SetPlayerInMiddleLane()
        {
            player.playerPosition = 1;
        }

    }
}
