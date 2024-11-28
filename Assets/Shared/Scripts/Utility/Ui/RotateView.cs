using UnityEngine;

namespace Utility.Ui
{
    public class RotateView : MonoBehaviour
    {
        [SerializeField] private Transform _root;
        [SerializeField] private Vector3 _rotation;
        [SerializeField] private float _speed;

        private void Update()
        {
            _root.Rotate(_rotation * (_speed * Time.deltaTime));
        }
    }
}