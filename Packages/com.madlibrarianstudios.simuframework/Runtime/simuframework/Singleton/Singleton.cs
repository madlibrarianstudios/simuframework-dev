// http://wiki.unity3d.com/index.php/Singleton

// Advantages 
// Globally accessible. No need to search for or maintain a reference to the class. 
// Persistent data. Can be used to maintain data across scenes. 
// Supports interfaces. Static classes can not implement interfaces. 
// Supports inheritance. Static classes can not inherent for another class. 
// The advantage of using singletons in Unity, rather than static parameters and methods, is that static classes are lazy-loaded when they are first referenced, but must have an empty static constructor (or one is generated for you). This means it's easier to mess up and break code if you're not careful and know what you're doing. As for using the Singleton Pattern, you automatically already do lots of neat stuff, such as creating them with a static initialization method and making them immutable. 
// Disadvantages 
// Must use the Instance keyword (e.g. <ClassName>.Instance) to access the singleton class. 
// There can only ever be one instance of the class active at a time. 
// Tight connections. Modifying the singleton can easily break all other code that depends on it. Requiring a lot of refactoring. 
// No polymorphism. 
// Not very testable. 


using UnityEngine;
 
/// <summary>
/// Inherit from this base class to create a singleton.
/// e.g. public class MyClassName : Singleton<MyClassName> {}
/// </summary>
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // Check to see if we're about to be destroyed.
    private static bool m_ShuttingDown = false;
    private static object m_Lock = new object();
    private static T m_Instance;
 
    /// <summary>
    /// Access singleton instance through this propriety.
    /// </summary>
    public static T Instance
    {
        get
        {
            if (m_ShuttingDown)
            {
                Debug.LogWarning("[Singleton] Instance '" + typeof(T) +
                    "' already destroyed. Returning null.");
                return null;
            }
 
            lock (m_Lock)
            {
                if (m_Instance == null)
                {
                    // Search for existing instance.
                    m_Instance = (T)FindObjectOfType(typeof(T));
 
                    // Create new instance if one doesn't already exist.
                    if (m_Instance == null)
                    {
                        // Need to create a new GameObject to attach the singleton to.
                        var singletonObject = new GameObject();
                        m_Instance = singletonObject.AddComponent<T>();
                        singletonObject.name = typeof(T).ToString() + " (Singleton)";
 
                        // Make instance persistent.
                        DontDestroyOnLoad(singletonObject);
                    }
                }
 
                return m_Instance;
            }
        }
    }
 
 
    private void OnApplicationQuit()
    {
        m_ShuttingDown = true;
    }
 
 
    private void OnDestroy()
    {
        m_ShuttingDown = true;
    }
}