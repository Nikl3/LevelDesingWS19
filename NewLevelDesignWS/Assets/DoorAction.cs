using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour {

    Animator animator;
    bool open = false;


    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void InteractDoor() {
        if (!open) {
            animator.Play("Auki_Huussi");
            open = true;

        } else {
            animator.Play("Kiinni_Huussi");
            open = false;
        }
    }

}
