using IndustrialMachineryPark.Model.Entities;
using IndustrialMachineryPark.Services;
using Microsoft.AspNetCore.Components;

namespace IndustrialMachineryPark.Components.Pages
{
    public partial class SendData
    {

       public Machine? Machine { get; set; }
        //private Machine? _machine;

        [Parameter]
        public string? MachineId { get; set; }

        protected override void OnParametersSet()
        {
          Machine =MachineService.GetMachine(MachineId);


        }

    }
}
