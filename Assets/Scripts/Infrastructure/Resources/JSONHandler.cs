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

        public JSONHandler(string resourceDirctory)
        {
            charas = load<Character>($"{resourceDirctory}/characters");
        }

        Dictionary<string, Character> IRepository.IResource.Characters()
        {
            return charas;
        }

        /// <summary>
        /// リソース読み取り
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resourceDirctory"></param>
        /// <returns></returns>
        public Dictionary<string, T> load<T>(string resourceDirctory)
            where T : JSONSerializer.Base
        {
            var json = Resources.Load<TextAsset>($"{resourceDirctory}/characters");
            var serializer = JsonUtility.FromJson<JSONSerializer.List<T>>(json.text);
            return serializer.list.ToDictionary(chara => chara.id);
        }
    }

}