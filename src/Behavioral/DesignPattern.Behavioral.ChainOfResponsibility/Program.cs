// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.ChainOfResponsibility.Handlers;
using DesignPattern.Behavioral.ChainOfResponsibility.Interfaces;
using DesignPattern.Behavioral.ChainOfResponsibility.Models;

ILogisticsHandler warehouseHandler = new WarehouseHandler();
ILogisticsHandler shippingHandler = new ShippingHandler();
ILogisticsHandler deliveryHandler = new DeliveryHandler();

warehouseHandler.SetSuccessor(shippingHandler);
shippingHandler.SetSuccessor(deliveryHandler);

Package package1 = new Package(5, "Local");
Package package2 = new Package(50, "Domestic");
Package package3 = new Package(150, "International");

warehouseHandler.HandlePackage(package1);
warehouseHandler.HandlePackage(package2);
warehouseHandler.HandlePackage(package3);