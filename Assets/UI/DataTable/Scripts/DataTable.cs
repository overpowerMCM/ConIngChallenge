using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI.DataTable
{
    public class DataTable : MonoBehaviour
    {
        TableModel _model;
        Row _header;
        List<Row> _rows = new List<Row>();
        public TableModel Model
        {
            get => _model;
            set
            {
                _model = value;
                SetDirty();
            }
        }

        void Clear()
        {
            _header.Dispose();
            _header = null;

            _rows.Clear();
        }

        void CreateHeader()
        {
            _header = GetRow();
            _header.transform.SetParent(transform, false);
            _header.Height = 120;
            _header.FontSize = 36;
            _header.Bold = true;

            string strHeaders = "";
            foreach (var e in Model.Headers)
            {
                strHeaders += e.Title+" ";
                Cell cell = GetCell();
                cell.Text = e.Title;
                _header.PushCell( cell );
            }


            Debug.Log(strHeaders);

        }

        private void SetDirty()
        {
            Debug.Log("Rebuild Header");

            CreateHeader();

            CreateRows();
        }

        private void CreateRows()
        {
            foreach (var r in Model.Rows)
            {
                string strRow = "";
                Row _row = GetRow();
                _row.transform.SetParent(transform, false);

                foreach (var o in r)
                {
                    strRow += o.ToString() + " ";
                    Cell cell = GetCell();
                    cell.Text = o.ToString();
                    _row.PushCell(cell);
                }

                _rows.Add(_row);
                Debug.Log(strRow);
            }
        }

        Row GetRow()
        {
            var prefab = Resources.Load("Prefabs/Row");
            GameObject obj = (GameObject)Instantiate(prefab);
            obj.name = "Row";
            return obj.GetComponent<Row>();
        }

        Cell GetCell()
        {
            var prefab = Resources.Load("Prefabs/Cell");
            GameObject obj = (GameObject)Instantiate(prefab);
            obj.name = "Cell";
            return obj.GetComponent<Cell>();
        }
    }
}
