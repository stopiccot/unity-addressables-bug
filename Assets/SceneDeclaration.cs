using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneDeclaration", menuName = "SceneDeclaration", order = 0)]
public class SceneDeclaration : ScriptableObject
{
    public string Name;
    public UnityEngine.AddressableAssets.AssetReference sceneReference;
}
