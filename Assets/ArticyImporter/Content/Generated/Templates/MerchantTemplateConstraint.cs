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
    
    
    public class MerchantTemplateConstraint
    {
        
        private MerchantInfoFeatureConstraint mMerchantInfo = new MerchantInfoFeatureConstraint();
        
        private CharacterInfoFeatureConstraint mCharacterInfo = new CharacterInfoFeatureConstraint();
        
        public MerchantInfoFeatureConstraint MerchantInfo
        {
            get
            {
                return mMerchantInfo;
            }
        }
        
        public CharacterInfoFeatureConstraint CharacterInfo
        {
            get
            {
                return mCharacterInfo;
            }
        }
    }
}
