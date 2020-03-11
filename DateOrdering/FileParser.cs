using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DateOrdering
{
    public class FileParser
    {
        private const string DateFormat = "dd/MM/yyyy";

        public List<Person> ReadFile()
        {
            using (StreamReader r = new StreamReader(""))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Person>>(json, new JsonSerializerSettings
                {
                    DateFormatString = DateFormat
                });
            }
        }
    }
}
