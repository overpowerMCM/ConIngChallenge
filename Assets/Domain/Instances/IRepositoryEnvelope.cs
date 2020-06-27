using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Domain.Instances
{
    public interface IRepositoryEnvelope
    {
        string[] GetHeaders();

        object[][] GetData();
    }
}
