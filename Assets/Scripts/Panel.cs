using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject player;
    public GameObject pauseWindow;
    public GameObject fadeOverlay;

    private PlayerController playerController;

    private float horizontalMove = 0;

    private void Start()
    {
        playerController = player.GetComponent<PlayerController>();
    }

    public void OnPressPause() {
        Time.timeScale = 0;
        pauseWindow.active = true;
        fadeOverlay.active = true;
        //GameManager.pauseGame();
    }

    public void OnPressJump()
    {
        playerController.UpdateJump();
    }

    public void OnTouchStartLeft()
    {
        horizontalMove = -1f;
    }

    public void OnTouchEndLeft()
    {
        horizontalMove = 0;
    }

    public void OnTouchStartRight()
    {
        horizontalMove = 1f;
    }

    public void OnTouchEndRight()
    {
        horizontalMove = 0;
    }

    void Update()
    {
        playerController.UpdateMove(horizontalMove);
    }
}
