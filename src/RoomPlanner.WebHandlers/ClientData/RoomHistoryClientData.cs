﻿using RoomPlanner.Domain;

namespace RoomPlanner.WebHandlers.ClientData
{
	public class RoomHistoryClientData
	{
		public string Date { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public RoomActionType ActionType { get; set; }
	}
}
