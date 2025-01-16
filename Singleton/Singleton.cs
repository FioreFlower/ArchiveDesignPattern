using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton _instance;
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameObject("Singleton").AddComponent<Singleton>();

            DontDestroyOnLoad(this);
            
            return _instance;
        }
    }
    
    private void Awake()
    {
        // Prevent duplicates
        if (_instance != null && _instance != this)
        {
            Destroy(this);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this);
    }

}
