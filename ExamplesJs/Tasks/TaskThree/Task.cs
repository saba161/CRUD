using ExamplesJs.Class.TaskThree.Models;
using ExamplesJs.Tasks.TaskThree.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExamplesJs.Class
{
    public class Task
    {
        public static List<NewReleases> LoadJson(string jsonFilePath)
        {
            using (StreamReader r = new StreamReader(jsonFilePath))
            {
                string json = r.ReadToEnd();
                List<NewReleases> items = JsonConvert.DeserializeObject<List<NewReleases>>(json);

                return items;
            }
        }

        public static List<VideoAndTitlePairs> MapList(List<NewReleases> list)
        {
            List<VideoAndTitlePairs> videoAndTitlePairs = new List<VideoAndTitlePairs>();

            foreach (var item in list)
            {
                videoAndTitlePairs.Add(
                    new VideoAndTitlePairs
                    {
                        Id = item.Id,
                        Title = item.Title
                    });
            }

            return videoAndTitlePairs;
        }
    }
}
