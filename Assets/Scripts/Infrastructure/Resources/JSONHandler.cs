using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Resource
{
    /// <summary>
    /// リソースへのアクセス
    /// </summary>
    public class JSONHandler : IRepository.IResource
    {
        private Dictionary<string, Character> charas;
        private Dictionary<string, Stage> stages;

        public JSONHandler(string resourceDirctory)
        {
            charas = load<Character>($"{resourceDirctory}/characters");
            stages = load<Stage>($"{resourceDirctory}/stages");
        }

        Dictionary<string, Character> IRepository.IResource.Characters()
        {
            return charas;
        }

        Dictionary<string, Stage> IRepository.IResource.Stages()
        {
            return stages;
        }

        /// <summary>
        /// リソース読み取り
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resourceDirctory"></param>
        /// <returns></returns>
        public Dictionary<string, T> load<T>(string path)
            where T : JSONSerializer.Base
        {
            var json = Resources.Load<TextAsset>(path);
            var serializer = JsonUtility.FromJson<JSONSerializer.List<T>>(json.text);
            return serializer.list.ToDictionary(chara => chara.id);
        }
    }

}