﻿namespace Synology.FileStation
{
	public static class SynologyConnectionExtension
	{
		private static FileStationApi _api;
		public static FileStationApi FileStation(this SynologyConnection connection)
		{
			return _api ?? (_api = connection.GetApi<FileStationApi>());
		}
	}
}
