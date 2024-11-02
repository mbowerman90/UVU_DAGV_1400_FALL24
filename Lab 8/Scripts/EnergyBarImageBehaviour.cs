using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class EnergyBarImageBehaviour : MonoBehaviour
    {
        private Image imageObj;
        private RectTransform rectTransform;
        public SimpleFloatData dataObj;
        private float energyScaler = 500f;
        private void Start()
        {
            imageObj = GetComponent<Image>();
            rectTransform = GetComponent<RectTransform>();
            dataObj.SetValue(0f);
        }

        public void Update()
        {
            imageObj.rectTransform.sizeDelta = new Vector2(dataObj.value * energyScaler, rectTransform.sizeDelta.y);
        }
    }

