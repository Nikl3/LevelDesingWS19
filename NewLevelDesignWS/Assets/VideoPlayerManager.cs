using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class VideoPlayerManager : MonoBehaviour {

    VideoPlayer vp;
    public GameObject videoScreen;
    public GameObject StartVideoFadeIN;
    public GameObject player;
    public GameObject audio;
    public Animator animator;


    void Start() {
        vp = GetComponent<VideoPlayer>();    
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.V)) {
            StartCoroutine("StartVideo");
        }
    }

    IEnumerator StartVideo() {
        animator.Play("Mitrrrorror");
        audio.GetComponent<AudioSource>().enabled = false;
        yield return new WaitForSeconds(.8f);

        StartVideoFadeIN.SetActive(true);
        yield return new WaitForSeconds(3f);
        videoScreen.SetActive(true);
        yield return new WaitForSeconds(3f);
        videoScreen.GetComponent<Animator>().Play("VideoStartFade");
        yield return new WaitForSeconds(1.5f);

        vp.Play();
        //yield return new WaitUntil(() => !vp.isPlaying);
        //print("jepa");
    }

    public void StartVideoClip() {
        StartCoroutine("StartVideo");
    }
}
