using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Garden
{

    public class FruitPlant : Plant
    {
        public GameObject fruit;

        internal override void PlantDone()
        {
            GameObject spawnFruit = Instantiate(fruit);
            spawnFruit.transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y,  -1f);
        }

        internal override void SetNextStage()
        {
            base.SetNextStage();

            if(stage == 3)
            {
                timerEnabled = true;
                timerStart = 0;
                stage = 4;
            }
            else if(stage == 4)
            {
                PlantDone();
                timerStart = 0;

            }

        }
    }   
}