using DG.Tweening;
using UnityEngine;

namespace Script.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 50.0f;
        [SerializeField] private Ease ease = Ease.Linear;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Alpha1))
                Move();
        }

        internal void Move()
        {
            transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
        }
    }
}