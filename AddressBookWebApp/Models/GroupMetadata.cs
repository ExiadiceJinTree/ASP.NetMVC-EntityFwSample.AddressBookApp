﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressBookWebApp.Models
{
    /// <summary>
    /// Groupモデルクラスに対する追加定義をするためのパーシャルクラス。
    /// </summary>
    [MetadataType(typeof(GroupMetadata))]  // 本モデルクラスに関連付けるメタデータクラスを指定
    public partial class Group
    {

    }

    /// <summary>
    /// Groupモデルクラスに関連付けるメタデータクラス。
    /// * モデルクラス(Entity,POCO)側にMetadataType属性でメタデータクラスを指定すると、
    ///   両クラスで名前が一致するプロパティについて、メタデータクラスで定義した属性をモデルクラスのプロパティに設定できる。
    /// * EntityFramework DB Firstで自動生成されたモデルクラス(Entity,POCO)に属性を定義するには、メタデータクラスを使用する必要がある。
    /// * メタデータクラス名: 何でもいいが、分かりやすくするために、対象モデルクラス名 + Metadata という命名が慣習である。
    /// </summary>
    public class GroupMetadata
    {
        [DisplayName("グループ名")]
        [Required]
        public string Name { get; set; }
    }
}