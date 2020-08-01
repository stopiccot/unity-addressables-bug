using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoaderScript : MonoBehaviour
{
    [SerializeField]
    AssetReference mainScene;

    private void Start()
    {
        Addressables.LoadSceneAsync(mainScene, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
}
