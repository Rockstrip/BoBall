using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class CollisionController : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            EndGame();
        }

        private void EndGame()
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
}