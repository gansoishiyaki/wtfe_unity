using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Resource
{
    /// <summary>
    /// リソースへのアクセス
    /// </summary>
    public class JSONHandler : IRepository.IResourceRepository
    {
        string resourceDirctory;
        Dictionary<string, Character> charas;

        public JSONHandler(string resourceDirctory)
        {
            this.resourceDirctory = resourceDirctory;
            charas = load<Character>($"{resourceDirctory}/characters");
        }

        List<Character> IRepository.IResourceRepository.Characters()
        {
            return charas.Values.ToList();
        }

        /// <summary>
        /// リソース読み取り
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resourceDirctory"></param>
        /// <returns></returns>
        public Dictionary<string, T> load<T>(string resourceDirctory)
            where T : Base
        {
            var json = Resources.Load<TextAsset>($"{resourceDirctory}/characters");
            var serializer = JsonUtility.FromJson<Serializer<T>>(json.text);
            return serializer.list.ToDictionary(chara => chara.id);
        }
    }

}