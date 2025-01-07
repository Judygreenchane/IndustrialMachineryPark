using IndustrialMachineryPark.Model.Entities;
using IndustrialMachineryPark.Services;
using Microsoft.AspNetCore.Components;


namespace IndustrialMachineryPark.Components.Pages
{
    public partial class SendDataToMachine
    {
        [Parameter]
        public int MachineId { get; set; }
        public Machine? Machine { get; set; }
       // private int _machineId;
        private string? data;
        protected override void OnInitialized()
        {
            Machine=MachineService.Machines.FirstOrDefault(m => m.Id == MachineId);
        }
        
        public void Close()
        {
            Machine = null;
        }
        public void UpdateLatestData()
        {

            MachineService.UpdateMachineData(MachineId, data);
          // Machine .LatestData = data;
        }
        

    }
}
