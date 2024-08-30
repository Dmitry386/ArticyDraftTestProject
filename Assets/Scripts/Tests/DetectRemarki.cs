using Articy.Dracula_articyXBasics;
using Articy.Unity;
using System.Collections.Generic;
using UnityEngine;

public class DetectRemarki : MonoBehaviour
{
    [SerializeField]
    private ArticyFlowPlayer _observe;

    private void Start()
    {
        _observe.onBranchesUpdated = OnUpdated;
    }

    private void OnUpdated(IList<Branch> aBranches)
    {
        foreach (var branch in aBranches)
        {
            Debug.Log(new string('=', 10));
            foreach (var path in branch.Path)
            {
                Debug.Log($"Type: {path.GetType()}, {path}");

                if (path is DialogueLine dialLine)
                {
                    Debug.Log($"Type: {path.GetType()}, {dialLine.Text}");
                }
                else if (path is OutputPin outPin)
                {
                    Debug.Log($"Type: {path.GetType()}, {outPin.Text}");
                }
                else if (path is OutgoingConnection outCon)
                {
                    Debug.Log($"Type: {path.GetType()}, {outCon.TargetPin}");
                }
                else if (path is InputPin inPin)
                {
                    Debug.Log($"Type: {path.GetType()}, {inPin.Text}");
                }
            }
        }
    }
}