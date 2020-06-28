using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class Row : MonoBehaviour, IDisposable
    {
        Stack<Cell> _cellStack = new Stack<Cell>();
        public Stack<Cell> Cells { get => _cellStack; }
        public float Height { get => _layout.minHeight; set => _layout.minHeight = value; }
        public Color Color { get; set; }

        LayoutElement _layout;
        Transform _cachedTransform;

        public bool Bold { get; set; }
        public int FontSize { get; set; }

        private void Awake()
        {
            _cachedTransform = transform;
            _layout = GetComponent<LayoutElement>();
            FontSize = 32;
        }

        public void PushCell(Cell cell)
        {
            _cellStack.Push(cell);
            cell.SetParent(_cachedTransform);
            cell.SetStyle(FontSize, Bold);
        }
        public Cell PopCell()
        {
            return _cellStack.Pop();
        }

        public void Dispose()
        {
            foreach (var cell in _cellStack)
            {
                Destroy(cell.gameObject);
            }
            _cellStack.Clear();
            Destroy(gameObject);
        }
    }
}
