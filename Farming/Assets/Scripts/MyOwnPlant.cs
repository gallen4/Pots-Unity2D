using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Garden
{

    public class MyOwnPlant : MonoBehaviour
    {
        public Sprite seedSprite;
        public Sprite bushSprite;
        public Sprite doneSprite;
        public Sprite WitheredSprite;


        internal int stage = 0;

        [SerializeField] private float stageTime;
        [SerializeField] internal bool timerEnabled;

        internal float timerStart = 0;
        

        private SpriteRenderer SpriteRenderer;


        void Start()
        {
            SpriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame          
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
                    SpriteRenderer.sprite = seedSprite;
                    timerStart = 0;
                    stage = 1;
                    break;
                case 1:
                    SpriteRenderer.sprite = bushSprite;
                    timerStart = 0;
                    stage = 2;
                    break;
                case 2:
                    SpriteRenderer.sprite = doneSprite;
                    timerStart = 0;
                    stage = 3;
                    break;
                case 3: 
                    SpriteRenderer.sprite = WitheredSprite;
                    timerStart = 0;
                    stage = 4;
                    break;
                case 4:
                    stage = 5;
                    PlantDone(); 
                    goto case 0;

            }

            
        }

        internal virtual void PlantDone()
        {
        }

    }



    

}
