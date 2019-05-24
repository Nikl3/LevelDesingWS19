using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionTrigger : MonoBehaviour {

    public Text interactionText;
    List<string> notifyTexts = new List<string>();
    public float notifyTime;
    float notifyTimer;

    public int pillsEaten;
    public List<GameObject> securityGuys;

    private void Start() {
        interactionText.text = "";
        notifyTimer = notifyTime;
    }

    public void Update() {
        if (notifyTexts.Count > 0) {
            interactionText.text = notifyTexts[0];
            notifyTimer -= Time.deltaTime;
            if (notifyTimer < 0) {
                notifyTexts.RemoveAt(0);
                if (notifyTexts.Count == 0) {
                    ResetText();
                }
                notifyTimer = notifyTime;
            }
        }
    }

        private void OnTriggerEnter(Collider other) {
        var interactable = other.GetComponent<Interactable>();
        if (interactable) {
        }
    }

    private void OnTriggerStay(Collider other) {
        var interactable = other.GetComponent<Interactable>();
        if (interactable) {
            if (notifyTexts.Count == 0) {
                interactionText.text = interactable.description;
            }

            if (Input.GetKeyDown(KeyCode.F)) {
                interactable.action.Invoke();
                RemoveSecurityGuy();
                pillsEaten++;
                if (pillsEaten == 3) {
                    // play sfx
                    // Open path to Tony Stark
                }

            }
        }

    } 

    private void OnTriggerExit(Collider other) {
        if (notifyTexts.Count == 0) {
            ResetText();
        }
    }

    public void ResetText() {
        interactionText.text = "";
    }
    public void NotifyText(string s) {
        notifyTexts.Add(s);

    }

    public void RemoveSecurityGuy() {
        // Play soundeffect
        Destroy(securityGuys[pillsEaten]);
    }
}
