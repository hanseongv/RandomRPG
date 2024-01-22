using UnityEngine;

namespace Script.Player
{
    public enum PlayerState
    {
        Idle,
        Move,
        Attack
    }

    public class PlayerFsm : MonoBehaviour
    {
        // Enum으로 상태 정의

        private PlayerState currentState;
    }
}