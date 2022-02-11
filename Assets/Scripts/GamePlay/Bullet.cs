using System;
using UnityEngine;

namespace GamePlay
{
    public class Bullet : MonoBehaviour
    {
        protected void OnBecameInvisible () {
            Destroy (gameObject);
        }
    }
}