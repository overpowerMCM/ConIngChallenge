using Domain.Instances;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace API.Services
{
    public class ServiceEnvelope
    {
        IRepositoryEnvelope _repository;
        public ServiceEnvelope(IRepositoryEnvelope repository)
        {
            _repository = repository;
        }

        public string Title
        {
            get => _repository.GetTitle();
        }

        public string[] ColumnsNames
        {

            get => _repository.GetHeaders();
        }

        public object[][] Rows
        {
            get => _repository.GetData();
        }

    }
}