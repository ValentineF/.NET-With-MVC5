using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Common
{
    public class JsonHandler
    {

        public static JsonMessage CreateMessage(int ptype, string pmessage, string pvalue)
        {
            JsonMessage json = new JsonMessage()
            {
                type = ptype,
                message = pmessage,
                value = pvalue
            };
            return json;
        }
        public static JsonMessage CreateMessage(int ptype, string pmessage)
        {
            JsonMessage json = new JsonMessage()
            {
                type = ptype,
                message = pmessage,
            };
            return json;
        }
    }

    public class JsonMessage
    {
        public int type { get; set; }
        public string message { get; set; }
        public string value { get; set; }
    }
}