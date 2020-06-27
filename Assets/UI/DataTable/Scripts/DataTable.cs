using UnityEngine;

namespace UI.DataTable
{
    public class DataTable : MonoBehaviour
    {
        TableModel _model;
        public TableModel Model { get=> _model;
            set
            {
                _model = value;
            }
        }
    }
}
