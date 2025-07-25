using FactoryX.Application.DTOs;
using System.Collections.Generic;

namespace FactoryX.Web.Models;

public class DashboardViewModel
{
    public int MachineCount { get; set; }
    public int ProductCount { get; set; }
    public int OperatorCount { get; set; }
    public int WorkOrderCount { get; set; }
    public int ProductionRecordCount { get; set; }
    public int ShiftCount { get; set; }
    public List<WorkOrderDto> RecentWorkOrders { get; set; } = new();
    public List<ProductionRecordDto> RecentProductionRecords { get; set; } = new();
}