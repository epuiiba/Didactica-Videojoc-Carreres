using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        public CarController car; // reference to the car controller, must be dragged in inspector

        [SerializeField] private Light leftLight;
        [SerializeField] private Light rightLight;
        private Renderer m_Renderer;


        private void Start()
        {
            m_Renderer = GetComponent<Renderer>();
        }


        private void Update()
        {
            // enable the Renderer when the car is braking, disable it otherwise.
            m_Renderer.enabled = car.BrakeInput > 0f;
            if(leftLight) leftLight.enabled = car.BrakeInput > 0f;
            if(rightLight) rightLight.enabled = car.BrakeInput > 0f;
        }
    }
}
