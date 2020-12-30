﻿using Controllers;
using UnityEngine;

namespace Items
{
    public class HelloBox : MonoBehaviour
    {
        public void SayHello()
        {
            Debug.Log($"Hello from game object \"{gameObject.name}\"");
            GameController.Instance.sceneLoadManager.StartStage(2);
        }
    }
}
