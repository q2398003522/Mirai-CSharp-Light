﻿using Mirai.CSharp.Light.Models.Data;
using Mirai.CSharp.Light.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirai.CSharp.Light.Handler
{
	/// <summary>
	/// Bot在群里的权限被改变事件处理接口
	/// </summary>
	public interface IBotGroupPermissionChangeEventHandler
	{
		/// <summary>
		/// 处理Bot在群里的权限被改变
		/// </summary>
		/// <param name="session">Mirai会话</param>
		/// <param name="e">Bot在群里的权限被改变事件信息</param>
		/// <returns>返回true中断后续的消息处理</returns>
		public bool HandleBotGroupPermissionChangeEvent(IMiraiSession session, IBotGroupPermissionChangeEventData e);
	}
}
