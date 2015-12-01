﻿/**
* Copyright 2015 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using UnityEngine;
using UnityEngine.UI;

namespace IBM.Watson.Widgets.Question
{
	/// <summary>
	/// Controls Parts of Speech Text item.
	/// </summary>
    public class POSTextItem : MonoBehaviour
    {
        [SerializeField]
        private Text m_POSTextField;

        private string m_POSWord;
        public string POSWord
        {
            get { return m_POSWord; }
            set
            {
                m_POSWord = value;
                UpdatePOSTextField();
            }
        }

        /// <summary>
        /// Update the POS view.
        /// </summary>
        private void UpdatePOSTextField()
        {
            m_POSTextField.text = POSWord;
        }
    }
}