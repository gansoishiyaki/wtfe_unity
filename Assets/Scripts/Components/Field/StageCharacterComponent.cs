using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Component
{
    /// <summary>
    /// ステージ内のキャラクターの操作
    /// </summary>
    public class StageCharacterComponent : MonoBehaviour
    {
        // public
        public SpriteRenderer spriteRenderer;

        // private
        private StageCharacterViewModel viewModel;

        /// <summary>
        /// viewModelのセット
        /// 初期処理
        /// </summary>
        /// <param name="viewModel"></param>
        public void setViewModel(StageCharacterViewModel viewModel)
        {
            this.viewModel = viewModel;

            // delegate
            viewModel.setPositon = delegate (Vector2 vector2)
            {
                transform.position = vector2;
            };
            viewModel.setSprite = delegate (Sprite sprite)
            {
                spriteRenderer.sprite = sprite;
            };

            viewModel.SetUp();
        }

        //------------------------------------------
        // タップ処理
        //------------------------------------------
        void OnMouseDown()
        {
            viewModel.tapStart();
        }

        void OnMouseUp()
        {
            viewModel.tapEnd();
        }

        private void OnMouseDrag()
        {
            viewModel.Drag();

            // TODO: 移動、攻撃判定
            //var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //var grid = GetComponentInParent<Grid>();
            //var tilePos = grid.WorldToCell(worldPos);
        }
    }
}
