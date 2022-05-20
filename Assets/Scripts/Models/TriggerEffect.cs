using System.Collections.Generic;
using System;

namespace Model.Trigger
{
    /// <summary>
    /// トリガー効果
    /// </summary>
    [Serializable]
    public class Effect
    {
        public string id;
        public string exec_type;
        public string target_type;
        public string rate_type;

        public List<string> grants; // 付与効果

        /// <summary>
        /// 起動時期
        /// </summary>
        public Exec Exec
        {
            get { return exec_type.ToEnum(Exec.begin); }
        }

        /// <summary>
        /// ターゲット
        /// </summary>
        public Target Target
        {
            get { return target_type.ToEnum(Target.enemy); }
        }

        /// <summary>
        /// 発動条件
        /// </summary>
        public Rate Rate
        {
            get { return target_type.ToEnum(Rate.hit); }
        }
    }

    /// <summary>
    /// Jsonシリアライズ用
    /// </summary>
    [Serializable]
    public class EffectSerializer
    {
        public List<Effect> trigger_effects;
    }
}