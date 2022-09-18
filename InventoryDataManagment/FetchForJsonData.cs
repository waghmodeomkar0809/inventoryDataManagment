using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryDataManagment
{
    public class FetchForJsonData
    {
        public Rice Read(string path)
        {
            using(StreamReader File = new StreamReader(path))
            {
                try
                {
                    string json = File.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);

                }
                catch (Exception)
                {
                    return null;
                }
            } 
        }
    }
}
