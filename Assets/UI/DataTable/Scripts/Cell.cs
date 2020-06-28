using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UI
{
    public class Cell : MonoBehaviour
    {
        [SerializeField]
        Text _text;
        Transform _cachedTransform;

        private void Awake()
        {
            _cachedTransform = transform;
        }

        public void SetStyle( int size, bool bold )
        {
            _text.fontSize = size;
            _text.fontStyle = bold ? FontStyle.Bold : FontStyle.Normal;
        }
        public string Text { get => _text.text; set => _text.text = value; }

        public void SetParent( Transform parent )
        {
            _cachedTransform.SetParent(parent, false);
        }
    }
}
