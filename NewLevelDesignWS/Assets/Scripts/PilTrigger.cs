using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilTrigger : MonoBehaviour {


    public void EatPill() {
        print("pill eaten");
        Destroy(gameObject);

    }
}
