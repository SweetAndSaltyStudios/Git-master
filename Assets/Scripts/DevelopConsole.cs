using System;
using TMPro;
using UnityEngine;

namespace Sweet_And_Salty_Studios
{
	public class DevelopConsole : MonoBehaviour
	{
		#region VARIABLES

		[SerializeField] private bool debug = default;
		[SerializeField] private DevelopConsoleInputField developConsoleInputField = default;

		#endregion VARIABLES

		#region PROPERTIES

        #endregion PROPERTIES

        #region UNITY FUNCTIONS

        #endregion UNITY FUNCTIONS

        #region CUSTOM FUNCTIONS

        public void OnValueChanged(string value)
		{
			// if(debug) Debug.Log($"OnValueChanged: {value}", gameObject);
		}

        public void OnEndEdit(string value)
		{
			//if(debug)Debug.Log($"OnEndEdit: {value}", gameObject);

			developConsoleInputField.ChangeNewLine(value);
		}

		public void OnSelect(string value)
		{
			// if(debug) Debug.Log($"OnSelect: {value}", gameObject);
		}

		public void OnDeselect(string value)
		{
			// if(debug) Debug.Log($"OnDeselect: {value}", gameObject);
		}

		#endregion CUSTOM FUNCTIONS	
	}
}