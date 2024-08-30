//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Dracula_articyXBasics.Features;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Dracula_articyXBasics
{
    
    
    public class Ingredient : Entity, IEntity, IPropertyProvider, IObjectWithFeatureIngredient, IObjectWithFeatureItemBasics
    {
        
        [SerializeField()]
        private ArticyValueIngredientTemplate mTemplate = new ArticyValueIngredientTemplate();
        
        private static Articy.Dracula_articyXBasics.Templates.IngredientTemplateConstraint mConstraints = new Articy.Dracula_articyXBasics.Templates.IngredientTemplateConstraint();
        
        public Articy.Dracula_articyXBasics.Templates.IngredientTemplate Template
        {
            get
            {
                return mTemplate.GetValue();
            }
            set
            {
                mTemplate.SetValue(value);
            }
        }
        
        public static Articy.Dracula_articyXBasics.Templates.IngredientTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        public IngredientFeature GetFeatureIngredient()
        {
            return Template.Ingredient;
        }
        
        public ItemBasicsFeature GetFeatureItemBasics()
        {
            return Template.ItemBasics;
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Ingredient newClone = ((Ingredient)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.Dracula_articyXBasics.Templates.IngredientTemplate)(Template.CloneObject(newClone, aFirstClassParent)));
            }
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if (aProperty.Contains("."))
            {
                Template.setProp(aProperty, aValue);
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if (aProperty.Contains("."))
            {
                return Template.getProp(aProperty);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
