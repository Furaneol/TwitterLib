﻿using System.Runtime.Serialization;

namespace TwitterLib.StreamingEvents
{
    /// <summary>
    /// ユーザーの情報およびツイートの閲覧が制限されたことを示す情報オブジェクトです。
    /// </summary>
    [DataContract]
    public class UserWithheldInfo : StreamingMessage
    {
        public override StreamingMessageType MessageType => StreamingMessageType.WithheldUser;
        public override Twitter Parent { get; internal set; }
        /// <summary>
        /// 閲覧制限を受けたユーザーのIDを取得します。
        /// </summary>
        [DataMember(Name = "id")]
        public ulong UserID { get; private set; }
        /// <summary>
        /// 閲覧制限を行った国を示すコードの一覧を取得します。
        /// </summary>
        [DataMember(Name = "user_withheld")]
        public string[] Countries { get; private set; }
    }
}
