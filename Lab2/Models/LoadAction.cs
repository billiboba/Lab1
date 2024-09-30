using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class LoadAction
    {
        public ActionParameters LoadActionParameters(string filePath, string actionName)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var allParameters = JsonSerializer.Deserialize<Dictionary<string, ActionParameters>>(json);
                if (allParameters != null && allParameters.ContainsKey(actionName))
                {
                    return allParameters[actionName];
                }
            }
            return null;
        }
    }
}
