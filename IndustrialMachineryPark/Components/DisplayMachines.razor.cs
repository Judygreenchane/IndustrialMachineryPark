using IndustrialMachineryPark.Model.Entities;
using IndustrialMachineryPark.Services;


namespace IndustrialMachineryPark.Components
{
    public partial class DisplayMachines
    {
        public Machine Machine { get; set; } = default!;
       
        public void RemoveMachine(Machine machine)
        {
            MachineService.RemoveMachine(machine);
        }
        public void StartMachine(Machine machine)
        {
            MachineService.StartMachine(machine);
        }
        public void StopMachine(Machine machine)
        {
            MachineService.StopMachine(machine);
        }
    }
    
}
