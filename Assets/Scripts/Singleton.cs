using System.Collections;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
	where T : MonoBehaviour {

	// The single instance of this class.
	private static T _instance;

	// The accessor. The first time this is called, _instance
	// will be set up. If an appropriate object can't be found,
	// an error will be logged.
	public static T instance {
		get {
			// If we haven't already set up _instance...
			if (_instance == null)
			{
				// Try to find the object.
				_instance = FindObjectOfType<T>();

				// Log if we can't find it.
				if (_instance == null) {
					Debug.LogError("Can't find " +
						typeof(T) + "!");
				}
			}

			// Return the instance so that it can be used!
			return _instance;
		}
	}
}
