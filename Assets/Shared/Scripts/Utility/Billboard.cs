using UnityEngine;

namespace Utility
{
    public class Billboard : MonoBehaviour
    {
        [Header("Look At Camera")]
        [SerializeField] private Transform _transform;
        
        private Transform _mainCamera;

        private bool _isSetup;
        
        private void OnEnable()
        {
            var mainCamera = Camera.main;
            if (mainCamera != null)
            {
                _mainCamera = mainCamera.transform;
                _isSetup = true;
            }
        }

        private void LateUpdate()
        {
            if (!_isSetup) return;
            var rotation = _mainCamera.rotation;
            _transform.LookAt((_mainCamera.position + rotation * Vector3.back) * -1, rotation * Vector3.up);
        }
    }
}