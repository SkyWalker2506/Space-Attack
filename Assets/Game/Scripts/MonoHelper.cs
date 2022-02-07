using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoHelper : MonoBehaviour
{
    public static MonoHelper Instance;
    public UnityEvent OnAwake;
    public UnityEvent OnStart;
    public UnityEvent OnUpdate;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Initialize()
    {
        if (Instance) return;
        Instance = new GameObject("CoroutineCaller").AddComponent<MonoHelper>();
        DontDestroyOnLoad(Instance.gameObject);
    }

    void Awake()
    {
        OnAwake?.Invoke();
    }

    void Start()
    {
        OnStart?.Invoke();
    }

    private void Update()
    {
        OnUpdate?.Invoke();
    }

}
