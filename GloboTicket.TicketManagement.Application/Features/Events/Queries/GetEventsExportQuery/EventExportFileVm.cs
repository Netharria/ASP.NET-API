﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExportQuery
{
    public class EventExportFileVm
    {
        public string EventExportFileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
