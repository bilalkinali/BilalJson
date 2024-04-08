using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BilalJson
{
    public class JsonConverter
    {
        string path;
        string txt;
        List<Movie> movies;
        public JsonConverter() 
        {
            path = "C:\\Users\\Bilal Kinali\\source\\repos\\BilalJson\\BilalJson\\TopratedRelations.json";
        }
        public async Task<List<Movie>> Get()
        {
            try
            {
                txt = await File.ReadAllTextAsync(path);

                if (!string.IsNullOrEmpty(txt))
                {
                    return new List<Movie>(JsonConvert.DeserializeObject<List<Movie>>(txt));
                }
            }
            catch (Exception)
            {
                
            }
            return new List<Movie>();
        }
    }
}
