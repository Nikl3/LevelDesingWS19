using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilTrigger : MonoBehaviour {

    public GameObject pilEffect;
    public GameObject player;
    ActionTrigger at;

    private void Start() {
        at = player.GetComponent<ActionTrigger>();
    }


    public void EatRedPill() {
        print("Red pill eaten");
        pilEffect.SetActive(true);
        PillEffect();
        Destroy(gameObject);

    }
    public void EatBluePill() {
        print("Blue pill eaten");
        pilEffect.SetActive(true);
        PillEffect();
        Destroy(gameObject);

    }
    public void EatYellowPill() {
        print("Yellow pill eaten");
        pilEffect.SetActive(true);
        PillEffect();
        Destroy(gameObject);

    }

    void PillEffect() {
        at.RemoveSecurityGuy();
        at.pillsEaten++;
        at.ResetText();
        if (at.pillsEaten == 3) {
            // play sfx
            // Open path to Tony Stark
        }
    }
}
