using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.DataTable
{
    public class TableModel
    {
        ColumnInfo[] _headers;
        object[][] _objects;

        bool _isDirty = false;
        public bool IsDirty { get => _isDirty; }

        public void AddRow( object[] obj )
        {
            _isDirty = true;
        }
    }
}
