using UnityEngine;
using System.Collections;

public class Singleton_Simple: MonoBehaviour {
    
#region Singleton
    private static Singleton_Simple _instance;
    public static Singleton_Simple Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
#endregion

	
}