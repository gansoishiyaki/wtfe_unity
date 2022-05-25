using UnityEngine;
using System.Diagnostics;

/// <summary>
/// デリゲートなど
/// </summary>
public class BaseViewModel
{
    //------------------------------------
    // delegate
    //------------------------------------
    // 生成
    public delegate GameObject CreateChild(GameObject obj, GameObject parent = null);
    public CreateChild createChild;

    // 移動
    public delegate void SetPositon(Vector2 vector2);
    public SetPositon setPositon;

    //------------------------------------
    // タップ判定
    //------------------------------------
    // タップの許可
    protected virtual bool isLongTapEnable { get { return false; } }
    protected virtual bool isDragEnable { get { return false; } }
    protected virtual bool isDraged
    {
        get { return _isDraged; }
        set { _isDraged = value; }
    }
    protected Vector2Int dragPos;
    private bool _isDraged = false;
    private bool isTapped = false;

    // ストップウォッチ
    private Stopwatch _stopwatch;
    private Stopwatch stopwatch
    {
        get
        {
            if (_stopwatch == null)
                _stopwatch = new Stopwatch();
            return _stopwatch;
        }
    }

    /// <summary>
    /// タップ開始
    /// </summary>
    public void tapStart()
    {
        stopwatch.Restart();
        isDraged = false;
        isTapped = false;
    }

    /// <summary>
    /// タップ終了
    /// </summary>
    public void tapEnd()
    {
        // タップされている場合は終了
        if (isTapped)
            return;

        // ドラッグ済みの場合はドラッグ判定
        if(isDragEnable && isDraged)
        {
            Draged(dragPos);
            return;
        }

        // いずれにも当てはまらない場合はシングルタップ
        SingleTap();
    }

    /// <summary>
    /// マウスを押し続けている
    /// </summary>
    public void Drag()
    {
        // 既にタップ処理が済んでいる場合、
        // 既にドラッグ処理が入っている場合、
        // ロングタップが許可されていない場合は
        // 終了
        if (isTapped ||
            isDraged ||
            !isLongTapEnable)
            return;

        // 一定時間押し続けていればロングタップを起動し、
        // タップ処理済みとする
        if(stopwatch.ElapsedMilliseconds >= Config.LongTapMilliSeconds)
        {
            isTapped = true;
            LongTap();
        }
    }

    /// <summary>
    /// 短くタップされた
    /// </summary>
    protected virtual void SingleTap() { }

    /// <summary>
    /// 長く押された
    /// </summary>
    protected virtual void LongTap() { }

    /// <summary>
    /// ドラッグ
    /// </summary>
    protected virtual void Draged(Vector2Int pos) { }
}