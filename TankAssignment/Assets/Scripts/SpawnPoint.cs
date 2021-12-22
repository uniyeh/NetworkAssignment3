using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanks
{
    public class SpawnPoint : MonoBehaviour
    {
        private GameObject defaultSpawnPoint;

        void Awake()
        {
            gameObject.SetActive(false);

        }
    }
}
