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
    
    
    public class CharacterInfoFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private BooleanConstraint mPlayableCharacter;
        
        private TextConstraint mBackground;
        
        private TextConstraint mMotivation;
        
        private TextConstraint mAppearance;
        
        private TextConstraint mVoiceActor;
        
        public BooleanConstraint PlayableCharacter
        {
            get
            {
                EnsureConstraints();
                return mPlayableCharacter;
            }
        }
        
        public TextConstraint Background
        {
            get
            {
                EnsureConstraints();
                return mBackground;
            }
        }
        
        public TextConstraint Motivation
        {
            get
            {
                EnsureConstraints();
                return mMotivation;
            }
        }
        
        public TextConstraint Appearance
        {
            get
            {
                EnsureConstraints();
                return mAppearance;
            }
        }
        
        public TextConstraint VoiceActor
        {
            get
            {
                EnsureConstraints();
                return mVoiceActor;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mPlayableCharacter = new Articy.Unity.Constraints.BooleanConstraint(false);
            mBackground = new Articy.Unity.Constraints.TextConstraint(400, "", null, true, true);
            mMotivation = new Articy.Unity.Constraints.TextConstraint(400, "", null, true, true);
            mAppearance = new Articy.Unity.Constraints.TextConstraint(400, "", null, true, true);
            mVoiceActor = new Articy.Unity.Constraints.TextConstraint(2048, "", null, false, false);
        }
    }
}
