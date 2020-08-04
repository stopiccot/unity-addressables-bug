using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SceneManager : MonoBehaviour
{
    public List<SceneDeclaration> scenes;

    public static SceneManager Instance { get; protected set; }
    protected static int counter = 0;
    protected int n = 0;

    void Start()
    {
        counter++;
        n = counter;

        if (Instance != null)
        {
            Debug.Log($"DESTROYING SceneManager {n} {counter}");
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        Instance = this;
    }

    void Update()
    {
        var text = $"{n} {counter} [";
        foreach (var s in scenes)
        {
            text = text + ((s != null) ? s.Name : "null") + ",";
        }
        text = text + "]";
        Debug.Log(text);
    }

    public void LoadScene1()
    {
        Addressables.LoadSceneAsync(scenes[0].sceneReference, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

    public void LoadScene2()
    {
        Addressables.LoadSceneAsync(scenes[1].sceneReference, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
}
