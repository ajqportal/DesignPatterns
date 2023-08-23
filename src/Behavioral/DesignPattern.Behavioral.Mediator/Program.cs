// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.Mediator.Components;
using DesignPattern.Behavioral.Mediator.Mediators;

LogisticsCoordinator mediator = new LogisticsCoordinator();

WarehouseComponent warehouse = new WarehouseComponent(mediator);
SupplierComponent supplier = new SupplierComponent(mediator);

mediator.Warehouse = warehouse;
mediator.Supplier = supplier;

warehouse.Send("We need more supplies.");
supplier.Send("New supplies are on the way.");
