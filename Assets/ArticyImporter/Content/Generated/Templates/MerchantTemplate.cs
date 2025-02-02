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
    public class MerchantTemplate : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueMerchantInfoFeature mMerchantInfo = new ArticyValueMerchantInfoFeature();
        
        [SerializeField()]
        private ArticyValueCharacterInfoFeature mCharacterInfo = new ArticyValueCharacterInfoFeature();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public Articy.Dracula_articyXBasics.Features.MerchantInfoFeature MerchantInfo
        {
            get
            {
                return mMerchantInfo.GetValue();
            }
            set
            {
                mMerchantInfo.SetValue(value);
            }
        }
        
        public Articy.Dracula_articyXBasics.Features.CharacterInfoFeature CharacterInfo
        {
            get
            {
                return mCharacterInfo.GetValue();
            }
            set
            {
                mCharacterInfo.SetValue(value);
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
                MerchantInfo.OwnerId = value;
                CharacterInfo.OwnerId = value;
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
                MerchantInfo.OwnerInstanceId = value;
                CharacterInfo.OwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Dracula_articyXBasics.Templates.MerchantTemplate newClone = ((Articy.Dracula_articyXBasics.Templates.MerchantTemplate)(aClone));
            if ((MerchantInfo != null))
            {
                newClone.MerchantInfo = ((Articy.Dracula_articyXBasics.Features.MerchantInfoFeature)(MerchantInfo.CloneObject(newClone, aFirstClassParent)));
            }
            if ((CharacterInfo != null))
            {
                newClone.CharacterInfo = ((Articy.Dracula_articyXBasics.Features.CharacterInfoFeature)(CharacterInfo.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Dracula_articyXBasics.Templates.MerchantTemplate clone = new Articy.Dracula_articyXBasics.Templates.MerchantTemplate();
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
                if ((featurePath == "MerchantInfo"))
                {
                    MerchantInfo.setProp(featureProperty, aValue);
                }
                if ((featurePath == "CharacterInfo"))
                {
                    CharacterInfo.setProp(featureProperty, aValue);
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
                if ((featurePath == "MerchantInfo"))
                {
                    return MerchantInfo.getProp(featureProperty);
                }
                if ((featurePath == "CharacterInfo"))
                {
                    return CharacterInfo.getProp(featureProperty);
                }
            }
            return null;
        }
        #endregion
    }
}
