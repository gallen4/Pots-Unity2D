using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Garden
{

    public class PlantCopy : MonoBehaviour
    {

        public GameObject originalPlant;

        public int stage = 0;

        [SerializeField] private float stageTime;
        [SerializeField] internal bool timerEnabled;

        internal float timerStart = 0;


        void Start()
        {

        }
        void Update()
        {

            if (timerEnabled)
            {
                timerStart += Time.deltaTime;

                if (timerStart > stageTime)
                {

                    SetNextStage();
                }
            }
        }
        internal virtual void SetNextStage()
        {
            switch (stage)
            {
                case 0:
                    GameObject spawnPlant = Instantiate(originalPlant);
                    spawnPlant.transform.position = new Vector3(-1.001f, 0.632f, -0.6539809f);
                    timerStart = 0;
                    stage = 1;
                    break;
                case 1:
                    timerStart = 0;
                    stage = 2;
                    break;
                case 2:
                    timerEnabled = false;
                    stage = 3;
                    break;

            }
        }




    }
}
