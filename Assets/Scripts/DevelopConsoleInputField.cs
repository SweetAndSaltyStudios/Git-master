using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Sweet_And_Salty_Studios
{
	public class DevelopConsoleInputField : TMP_InputField
	{
        #region VARIABLES

        [SerializeField] private DevelopConsole developConsole;
        
        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY FUNCTIONS

        #endregion UNITY FUNCTIONS

        #region CUSTOM FUNCTIONS

        public override void OnSubmit(BaseEventData eventData)
        {
            base.OnSubmit(eventData);

            Debug.Log($"OnSubmit", gameObject);
        }

        public void ChangeNewLine(string value)
        {
            text = $"{value}\n";
            caretPosition = value.Length + 1;
            ActivateInputField();
        }

        #endregion CUSTOM FUNCTIONS	
    }
}