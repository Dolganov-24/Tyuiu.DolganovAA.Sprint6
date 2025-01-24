﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DolganovAA.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] res = line.Split(' ');
                    for (int i = 0; i < res.Length; i++)
                    {
                        if (res[i].Contains("n"))
                        {
                            resStr += res[i] + " ";
                        }

                    }
                }
            }
            return resStr;
        }
    }
}