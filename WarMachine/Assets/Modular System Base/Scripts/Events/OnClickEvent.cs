﻿using UnityEngine;

namespace WARMachine.Events
{
    public class OnClickEvent : MonoBehaviour
    {
        [Tooltip("Event To Raise")]
        public GameEvent Event;

        private void OnMouseDown()
        {
            Debug.Log("this was click");
            Event.Raise();
        }
    }
}
