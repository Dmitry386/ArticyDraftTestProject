//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Dracula_articyXBasics;
using Articy.Dracula_articyXBasics.Features;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Dracula_articyXBasics.Templates
{
    
    
    [Serializable()]
    public class DialogueLineTemplate : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueDialogueFragmentFeature mDialogueFragment = new ArticyValueDialogueFragmentFeature();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public Articy.Dracula_articyXBasics.Features.DialogueFragmentFeature DialogueFragment
        {
            get
            {
                return mDialogueFragment.GetValue();
            }
            set
            {
                mDialogueFragment.SetValue(value);
            }
        }
        
        public UInt64 OwnerId
        {
            get
            {
                return mOwnerId;
            }
            set
            {
                mOwnerId = value;
                DialogueFragment.OwnerId = value;
            }
        }
        
        public UInt32 OwnerInstanceId
        {
            get
            {
                return mOwnerInstanceId;
            }
            set
            {
                mOwnerInstanceId = value;
                DialogueFragment.OwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Dracula_articyXBasics.Templates.DialogueLineTemplate newClone = ((Articy.Dracula_articyXBasics.Templates.DialogueLineTemplate)(aClone));
            if ((DialogueFragment != null))
            {
                newClone.DialogueFragment = ((Articy.Dracula_articyXBasics.Features.DialogueFragmentFeature)(DialogueFragment.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Dracula_articyXBasics.Templates.DialogueLineTemplate clone = new Articy.Dracula_articyXBasics.Templates.DialogueLineTemplate();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "DialogueFragment"))
                {
                    DialogueFragment.setProp(featureProperty, aValue);
                }
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "DialogueFragment"))
                {
                    return DialogueFragment.getProp(featureProperty);
                }
            }
            return null;
        }
        #endregion
    }
}
