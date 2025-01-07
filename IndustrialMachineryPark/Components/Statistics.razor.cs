using IndustrialMachineryPark.Model.Entities;
using IndustrialMachineryPark.Services;

namespace IndustrialMachineryPark.Components
{
    public partial  class Statistics
    {
        private int? machineCount;
        private int? onlineMachineCount;
        private Machine LastEditedMachine;
        protected async override Task OnInitializedAsync()
        {

            machineCount = MachineService.MachinesOnline;
            onlineMachineCount = MachineService.TotalMachines;
            LastEditedMachine = MachineService.LastUpdatedMachine;
        }
    }
}
