﻿using System;

namespace GameServer.Networking
{
	
	[PacketInfoAttribute(来源 = PacketSource.Client, 编号 = 523, 长度 = 6, 注释 = "取消好友关注")]
	public sealed class 取消好友关注 : GamePacket
	{
		
		public 取消好友关注()
		{
			
			
		}

		
		[WrappingFieldAttribute(SubScript = 2, Length = 4)]
		public int 对象编号;
	}
}