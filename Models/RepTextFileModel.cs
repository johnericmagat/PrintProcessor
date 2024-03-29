﻿using System;
using System.Collections.Generic;

namespace PrintProcessor.Models
{
	public class RepTextFileModel
	{
		public Int32 SalesId { get; set; }
		public Int32 CollectionId { get; set; }
		public Int32 TerminalId { get; set; }
		public String Type { get; set; }
		public String Printer { get; set; }
		public String EntryDateTime { get; set; }
        public List<SysGeneralSettingsModel> GeneralSettings { get; set; }
    }
}
