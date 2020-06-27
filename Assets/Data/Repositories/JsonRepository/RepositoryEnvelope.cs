using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Domain.Instances;
using System.IO;
using LitJson;
namespace Data.Repositories.JsonRepository
{
    public class RepositoryEnvelope : IRepositoryEnvelope
    {
        readonly string _jsonPath = "";

        public RepositoryEnvelope()
        {
            _jsonPath = Path.Combine(Application.streamingAssetsPath, "JsonChallenge.json");
        }
        public object[][] GetData()
        {
            string strJson = File.ReadAllText(_jsonPath);
            JsonData json = JsonMapper.ToObject(strJson);

            JsonData data = json["Data"];

            List<object[]> objects = new List<object[]>();

            for (int i = 0; i < data.Count; i++)
            {
                JsonData dataObject = data[i];
                ICollection<string> dataKeys = dataObject.Keys;
                List<object> values = new List<object>();

                foreach( string key in dataKeys)
                {
                    values.Add(dataObject[key].ToString());
                }

                objects.Add(values.ToArray());
            }
            return objects.ToArray();
        }

        public string[] GetHeaders()
        {
            string strJson = File.ReadAllText(_jsonPath);
            JsonData json = JsonMapper.ToObject(strJson);
            JsonData columnHeaders = json["ColumnHeaders"];
            List<string> headers = new List<string>();

            for (int i = 0; i < columnHeaders.Count; i++)
            {
                headers.Add( columnHeaders[i].GetString() );
            }

            return headers.ToArray();
        }
    }
}
