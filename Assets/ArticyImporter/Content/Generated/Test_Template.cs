//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Dracula_articyXBasics
{
    
    
    public class Test_Template : Entity, IEntity, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueTest_TemplateTemplate mTemplate = new ArticyValueTest_TemplateTemplate();
        
        private static Articy.Dracula_articyXBasics.Templates.Test_TemplateTemplateConstraint mConstraints = new Articy.Dracula_articyXBasics.Templates.Test_TemplateTemplateConstraint();
        
        public Articy.Dracula_articyXBasics.Templates.Test_TemplateTemplate Template
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
        
        public static Articy.Dracula_articyXBasics.Templates.Test_TemplateTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Test_Template newClone = ((Test_Template)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.Dracula_articyXBasics.Templates.Test_TemplateTemplate)(Template.CloneObject(newClone, aFirstClassParent)));
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
