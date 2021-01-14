using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExportQuery
{
    public class GetEventsExportQuery: IRequest<EventExportFileVm>
    {
    }
}
