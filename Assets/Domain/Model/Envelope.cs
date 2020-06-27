using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Domain.Model
{
    public class Envelope
    {
        public string Title { get; set; }   
        public string[] Headers { get; set; }
        public object[][] Data { get; set; }

    }
}