using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilTrigger : MonoBehaviour {

    public GameObject pilEffect;

    public void EatRedPill() {
        print("Red pill eaten");
        pilEffect.SetActive(true);
        Destroy(gameObject);

    }
    public void EatBluePill() {
        print("Blue pill eaten");
        pilEffect.SetActive(true);
        Destroy(gameObject);

    }
    public void EatYellowPill() {
        print("Yellow pill eaten");
        pilEffect.SetActive(true);
        Destroy(gameObject);

    }
}
