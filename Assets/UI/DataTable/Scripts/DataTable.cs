using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI.DataTable
{
    public class DataTable : MonoBehaviour
    {
        TableModel _model;
        public TableModel Model
        {
            get => _model;
            set
            {
                _model = value;
                SetDirty();
            }
        }

        private void SetDirty()
        {
            Debug.Log("Rebuild Header");
            string strHeaders = "";
            foreach (var e in Model.Headers)
            {
                strHeaders += e.Title+" ";
            }
            Debug.Log(strHeaders);

            foreach ( var r in Model.Rows )
            {
                string strRow = "";
                foreach (var o in r)
                {
                    strRow += o.ToString() + " ";
                }
                Debug.Log(strRow);
            }
        }
    }
}
