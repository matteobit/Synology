﻿using System;
using System.Dynamic;
using System.Configuration;

namespace Synology.FileStation.FileShare.Results
{
	public class ShareResult
	{
		public string Path { get; set; }

		public string Name { get; set; }

		public ShareAdditionalResult Additional { get; set; }
	}
}

