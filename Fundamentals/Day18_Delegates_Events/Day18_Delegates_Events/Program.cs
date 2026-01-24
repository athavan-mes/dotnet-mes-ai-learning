using Day18_Delegates_Events.Models;
using Day18_Delegates_Events.Service;

var machine = new Machine("CNC-01");

var mesService = new MesService();

machine.StatusChanged += mesService.OnMachineStatusChanged;

machine.Start();
machine.Stop();
