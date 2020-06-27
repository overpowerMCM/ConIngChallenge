using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Domain.Instances
{
    public interface IRepositoryEnvelope
    {
        string GetTitle();
        string[] GetHeaders();

        object[][] GetData();
    }
}
