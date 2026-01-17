using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    //[SerializeField] float speedOfPlayer;

    private void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float inputMoveX = 0;

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            inputMoveX = -1;
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            inputMoveX = 1;
        }

        Vector2 deltaPos = new Vector2();
        deltaPos.x += inputMoveX;
        transform.Translate(deltaPos);
    }
}
