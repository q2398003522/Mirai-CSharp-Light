﻿using Mirai.CSharp.Light.Extensions;
using Mirai.CSharp.Light.Models.Message;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
#pragma warning disable CS8602 // 解引用可能出现空引用。
#pragma warning disable CS8603 // 可能返回 null 引用。
#pragma warning disable CS8604 // 引用类型参数可能为 null。
namespace Mirai.CSharp.Light.Models.Data
{
	internal class FriendMessageData : IFriendMessageData
	{
		public string type = "";

		[JsonIgnore]
		public string Type { get => type; set => type = value; }

		public UserData sender = new();

		[JsonIgnore]
		public IUserData Sender => sender;

		[JsonIgnore]
		public IChatMessage[] messageChain = Array.Empty<IChatMessage>();

		[JsonIgnore]
		public IChatMessage[] MessageChain => messageChain;

		public static FriendMessageData Parse(JObject json)
		{
			var result = JsonConvert.DeserializeObject<FriendMessageData>(json.ToString(Formatting.None));
			result.messageChain = ((JArray)json["messageChain"]).ToIChatMessageArray();
			return result;
		}
	}
}
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
#pragma warning restore CS8602 // 解引用可能出现空引用。
#pragma warning restore CS8603 // 可能返回 null 引用。
#pragma warning restore CS8604 // 引用类型参数可能为 null。