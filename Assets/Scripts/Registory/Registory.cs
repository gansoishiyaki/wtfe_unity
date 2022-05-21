using System;
using IRepository;

/// <summary>
/// 各層の繋ぎを行うレジストリクラス
/// </summary>
public class Registory
{
    public ICharacterService chara;

    public Registory(IResourceRepository resource)
    {

    }
}
