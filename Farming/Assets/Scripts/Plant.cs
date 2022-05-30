using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Garden
{

    public class Plant : MonoBehaviour
    {
        public Sprite seedSprite;
        public Sprite bushSprite;
        public Sprite doneSprite;
      

        public int stage = 0;

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
            if(timerEnabled)
            {
                timerStart += Time.deltaTime;

                if(timerStart > stageTime)
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
                    SpriteRenderer.sprite = bushSprite;
                    timerStart = 0;
                    stage = 1;
                    break;
                case 1:
                    SpriteRenderer.sprite = doneSprite;
                    timerStart = 0;
                    stage = 2;
                    break;
                case 2:
                    timerEnabled = false;
                    stage = 3;
                    PlantDone();
                    break;
                    
            }
        }

            internal virtual void PlantDone()
            {
            }

        }

    }

