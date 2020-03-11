using Newtonsoft.Json;
using System;

namespace DateOrdering
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonProperty("finished_date")]
        public DateTime FinishDate { get; set; }

        public override string ToString()
        {
            return $" {Id} {Name} finished on {FinishDate} {Environment.NewLine} {DateConversion.GetDetails(FinishDate, DateTime.Now)} ";
        }
    }
}
