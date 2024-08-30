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
using Articy.Unity.Constraints;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Dracula_articyXBasics.Features
{
    
    
    public class WeaponFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private NumberConstraint mCombatModifier;
        
        private NumberConstraint mUses;
        
        public NumberConstraint CombatModifier
        {
            get
            {
                EnsureConstraints();
                return mCombatModifier;
            }
        }
        
        public NumberConstraint Uses
        {
            get
            {
                EnsureConstraints();
                return mUses;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mCombatModifier = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, null);
            mUses = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, null);
        }
    }
}
