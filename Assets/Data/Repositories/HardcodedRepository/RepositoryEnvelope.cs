using Domain.Instances;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Data.Repositories.HardcodedRepository
{
    public class RepositoryEnvelope : IRepositoryEnvelope
    {
        string[] _headers;
        object[][] _data;
        public RepositoryEnvelope()
        {
            _headers = new string[] { "Nickname", "Nombre", "Apellido", "Cita" };
            _data = new object[][] 
            {
                new object[] 
                {
                    "Overpower", "Pablo", "Oberauer", "I made this!!!"
                },
                new object []
                {
                    "Comodin", "Juan", "Perez", "Quien otro?"
                },
                new object []
                {
                    "Dragon", "Bruce", "Lee", "Be like water."
                },
                new object []
                {
                    "The King", "Roberto", "Carlos", "Tengo 1000000 de amigos"
                }
            };
        }

        public object[][] GetData()
        {
            return _data;
        }

        public string[] GetHeaders()
        {
            return _headers;
        }

        public string GetTitle()
        {
            return "Citas";
        }
    }
}
