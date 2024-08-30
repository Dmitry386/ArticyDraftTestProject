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
    
    
    public class ItemBasicsFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private BooleanConstraint mQuestItem;
        
        private TextConstraint mFlavorText;
        
        private NumberConstraint mSalesValue;
        
        public BooleanConstraint QuestItem
        {
            get
            {
                EnsureConstraints();
                return mQuestItem;
            }
        }
        
        public TextConstraint FlavorText
        {
            get
            {
                EnsureConstraints();
                return mFlavorText;
            }
        }
        
        public NumberConstraint SalesValue
        {
            get
            {
                EnsureConstraints();
                return mSalesValue;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mQuestItem = new Articy.Unity.Constraints.BooleanConstraint(false);
            mFlavorText = new Articy.Unity.Constraints.TextConstraint(280, "", null, true, true);
            mSalesValue = new Articy.Unity.Constraints.NumberConstraint(0D, 1000D, 0, 0, 0, null);
        }
    }
}
