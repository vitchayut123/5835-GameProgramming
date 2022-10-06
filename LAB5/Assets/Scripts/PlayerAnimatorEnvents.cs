using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorEnvents : MonoBehaviour
{
    [SerializeField] private PlayerAudioController audioContrller;

    public void PlayerWalkSound()
    {
        audioContrller.PlayWalkSound();
    }
}
