using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilTrigger : MonoBehaviour {


    public void EatRedPill() {
        print("Red pill eaten");
        Destroy(gameObject);

    }
    public void EatBluePill() {
        print("Blue pill eaten");
        Destroy(gameObject);

    }
    public void EatYellowPill() {
        print("Yellow pill eaten");
        Destroy(gameObject);

    }
}
