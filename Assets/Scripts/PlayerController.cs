using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerInputs PlayerInputs {  get; private set; }
    public PlayerInputs.PlayerActions PlayerActions { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        PlayerInputs = new PlayerInputs();
        PlayerActions = PlayerInputs.Player;
    }

    private void OnEnable()
    {
        PlayerInputs.Enable();
    }

    private void OnDisable()
    {
        PlayerInputs.Disable();
    }
}
