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
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Dracula_articyXBasics.Features
{
    
    
    [Serializable()]
    public class WeaponFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private Int32 mCombatModifier;
        
        [SerializeField()]
        private Int32 mUses;
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public Int32 CombatModifier
        {
            get
            {
                return mCombatModifier;
            }
            set
            {
                var oldValue = mCombatModifier;
                mCombatModifier = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "Weapon.CombatModifier", oldValue, mCombatModifier);
            }
        }
        
        /// <summary>
        /// Number of times item can be used
        /// </summary>
        public Int32 Uses
        {
            get
            {
                return mUses;
            }
            set
            {
                var oldValue = mUses;
                mUses = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "Weapon.Uses", oldValue, mUses);
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
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Dracula_articyXBasics.Features.WeaponFeature newClone = ((Articy.Dracula_articyXBasics.Features.WeaponFeature)(aClone));
            newClone.CombatModifier = CombatModifier;
            newClone.Uses = Uses;
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Dracula_articyXBasics.Features.WeaponFeature clone = new Articy.Dracula_articyXBasics.Features.WeaponFeature();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "CombatModifier"))
            {
                CombatModifier = System.Convert.ToInt32(aValue);
                return;
            }
            if ((aProperty == "Uses"))
            {
                Uses = System.Convert.ToInt32(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "CombatModifier"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(CombatModifier);
            }
            if ((aProperty == "Uses"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Uses);
            }
            return null;
        }
        #endregion
    }
}
