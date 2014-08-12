using UnityEngine;
using System.Collections;
using Chartboost;

public class ChartboostConfig : MonoBehaviour {

    public static bool wasShown = false;

    void Awake() {
        #if UNITY_ANDROID
		CBBinding.init("53e988de89b0bb54c915b841", "2d13bde84275bb908d1acc64c0d8aae310061f26");
        #elif UNITY_IPHONE
            CBBinding.init("3333", "4444");
        #endif
    }

    void Start() {
        CBBinding.cacheInterstitial("Default");
    }

}
