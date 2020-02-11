using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer_Script : MonoBehaviour
{
    public enum PlayerState
    {
        ENABLED, DISABLED, DIALOGUE
    };

    public float        rayDistance;

    private PlayerState _currentState = PlayerState.ENABLED;

    private void LateUpdate()
    {
        switch (_currentState)
        {
            case PlayerState.ENABLED:
                if (Input.GetButtonDown("Fire1"))
                {
                    RaycastHit hit;
                    if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance) &&
                         hit.collider.CompareTag("Canvas"))
                    {
                        Debug.Log("HIT");
                    }
                }
                break;
            case PlayerState.DISABLED:
                break;
            case PlayerState.DIALOGUE:
                break;
            default:
                break;
        }
    }
}
