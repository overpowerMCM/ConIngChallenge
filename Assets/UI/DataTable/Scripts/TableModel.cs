using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.DataTable
{
    public class TableModel
    {
        ColumnInfo[] _headers;
        List< object[] > _rows;

        bool _isDirty = false;
        public bool IsDirty { get => _isDirty; set => _isDirty = value; }
        public ColumnInfo[] Headers { get => _headers; set => _headers = value; }
        public TableModel()
        {
            _rows = new List< object[] >();
        }

        public object[][] Rows
        {
            get => _rows.ToArray();
            set
            {
                _rows.Clear();
                _rows.AddRange( value );
                _isDirty = true;
            }
        }

        public void AddRow( object[] obj )
        {
            _rows.Add(obj);
            _isDirty = true;
        }

        public bool DeleteRow(int index)
        {
            if (index >= 0 && index < _rows.Count)
            {
                _rows.RemoveAt(index);
                _isDirty = true;
            }
            return false;
        }

    }
}
