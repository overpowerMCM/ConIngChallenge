﻿using API.Services;
using Data.Repositories.JsonRepository;
using System.Collections;
using System.Collections.Generic;
using UI.DataTable;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeManager : MonoBehaviour
{
    [SerializeField]
    DataTable _dataTable;

    [SerializeField]
    Text _title;

    ServiceEnvelope _service;
    // Start is called before the first frame update
    private void Awake()
    {
        _service = new ServiceEnvelope( new RepositoryEnvelope() );
    }

    public void RebuildTable()
    {
        _title.text = _service.Title;

        List<ColumnInfo> columnInfo = new List<ColumnInfo>();

        string[] columnNames = _service.ColumnsNames;

        for (int i = 0; i < columnNames.Length; i++)
        {
            columnInfo.Add(new ColumnInfo()
            {
                Title = columnNames[i]
            });
        }

        TableModel tableModel = new TableModel()
        {
            Headers = columnInfo.ToArray(),
            Rows = _service.Rows
        };

        _dataTable.Model = tableModel;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
