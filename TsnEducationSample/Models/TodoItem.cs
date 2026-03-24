using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TsnEducationSample.Models
{
    //TODOアイテム管理用クラス
    public class TodoItem
    {

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        public string Description { get; set; }

        #region yamanaka追加分
        /// <summary>
        /// 難易度
        /// </summary>
        public string Difficult { get; set; }

        /// <summary>
        /// 優先度
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// 期限時間
        /// </summary>
        public string Time { get; set; }
        #endregion

        #region nakano追加分
        /// <summary>
        /// 期日
        /// </summary>
        public string day { get; set; }
        #endregion

    }
}