using Domain.Instances;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace API.Services
{
    public class ServiceEnvelope
    {
        IRepositoryEnvelope _repository;
        public ServiceEnvelope( IRepositoryEnvelope repository )
        {
            _repository = repository;
        }

        public string[] GetColumnsNames()
        {
            return _repository.GetHeaders();
        }

        public object[][] GetRows()
        {
            return _repository.GetData();
        }

    }
}