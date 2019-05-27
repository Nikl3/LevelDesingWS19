using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour {

    Animator animator;
    bool open = false;
    public string openDoor;
    public string closeDoor;



    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void InteractDoor() {
        if (!open) {
            animator.Play(openDoor);
            open = true;

        } else {
            animator.Play(closeDoor);
            open = false;
        }
    }

}
