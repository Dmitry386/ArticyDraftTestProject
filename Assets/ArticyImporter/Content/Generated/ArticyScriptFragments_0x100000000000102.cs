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


namespace Articy.Dracula_articyXBasics.GlobalVariables
{
    
    
    public partial class ArticyScriptFragments : BaseScriptFragments, ISerializationCallbackReceiver
    {
        
        #region Script fragments
        /// <summary>
        /// ObjectID: 0x10000000000387D
        /// Articy Object ref: articy://localhost/view/0522ed71-cf56-4aa1-8c8f-6f3d1534325d/72057594037942397?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_720575940379281940x10000000000387DText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return // Hides node when visited
aGlobalVariablesState.Unseen;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000003883
        /// Articy Object ref: articy://localhost/view/0522ed71-cf56-4aa1-8c8f-6f3d1534325d/72057594037942403?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_720575940379281940x100000000003883Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return // Hides node when visited
aGlobalVariablesState.Unseen;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000003889
        /// Articy Object ref: articy://localhost/view/0522ed71-cf56-4aa1-8c8f-6f3d1534325d/72057594037942409?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_720575940379281940x100000000003889Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return // Option only visible if above nodes have been visited.
fallback(aGlobalVariablesState, aMethodProvider);
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000388F
        /// Articy Object ref: articy://localhost/view/0522ed71-cf56-4aa1-8c8f-6f3d1534325d/72057594037942415?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_720575940379281940x10000000000388FText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return // Option only visible if Mina has stake item or is level 3 or higher
aGlobalVariablesState.Inventory.stake == true || aGlobalVariablesState.GameState.playerLevel > 2
;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000003953
        /// Articy Object ref: articy://localhost/view/0522ed71-cf56-4aa1-8c8f-6f3d1534325d/72057594037942611?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_720575940379281940x100000000003953Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return // did Mina defeat Renfield?
aGlobalVariablesState.GameState.isRenfieldDefeated == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000036C9
        /// Articy Object ref: articy://localhost/view/0522ed71-cf56-4aa1-8c8f-6f3d1534325d/72057594037941961?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_720575940379281940x1000000000036C9Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return // Was Mina's name revealed to Dracula earlier?
aGlobalVariablesState.GameState.isNameRevealed == true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000003D1C
        /// Articy Object ref: articy://localhost/view/0522ed71-cf56-4aa1-8c8f-6f3d1534325d/72057594037943580?pane=selected&amp;tab=current
        /// </summary>
        public void Script_720575940379281940x100000000003D1CExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            //Mina's name was revealed to Dracula in this branch
aGlobalVariablesState.GameState.isNameRevealed = true;
        }
        #endregion
        
        #region Unity serialization
        public virtual void OnAfterDeserialize_0x100000000000102()
        {
            Conditions.Add(3045623881u, this.Script_720575940379281940x10000000000387DText);
            Conditions.Add(3050907062u, this.Script_720575940379281940x100000000003883Text);
            Conditions.Add(827044446u, this.Script_720575940379281940x100000000003889Text);
            Conditions.Add(1205097887u, this.Script_720575940379281940x10000000000388FText);
            Conditions.Add(2580079515u, this.Script_720575940379281940x100000000003953Expression);
            Conditions.Add(3996674382u, this.Script_720575940379281940x1000000000036C9Expression);
            Instructions.Add(3361669324u, this.Script_720575940379281940x100000000003D1CExpression);
        }
        #endregion
    }
}
