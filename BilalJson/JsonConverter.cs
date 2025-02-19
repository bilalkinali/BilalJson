﻿using System;
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
            path = "TopratedRelations.json"; // "..\bin\Debug\net6.0-windows\TopratedRelations.json"
            movies = new List<Movie>();
        }
        public async Task<List<Movie>> Get()
        {
            try
            {
                txt = await File.ReadAllTextAsync(path);

                if (!string.IsNullOrEmpty(txt))
                {
                    return JsonConvert.DeserializeObject<List<Movie>>(txt).DistinctBy(m => m.MovieId).ToList();
                }
            }
            catch (Exception)
            {

            }
            return movies;
        }
    }
}
