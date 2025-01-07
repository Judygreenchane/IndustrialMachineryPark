
using System.Collections.Generic;
using IndustrialMachineryPark.Model.Entities;



namespace IndustrialMachineryPark.Services
{
    public class MachineService
    {
       // public int MachineId
        public static List<Machine> Machines { get; set; } = new List<Machine>();
        public static Machine LastUpdatedMachine { get; set; } = new Machine();
        public void AddMachine(Machine  machine)
        {
            Machines.Add(machine);
        }

        public void RemoveMachine(Machine machine)
        {
            Machines.Remove(machine);
        }
        public void StartMachine(Machine machine)
        {
            machine .IsOnline = true;
           // Machines.Remove(machine);
        }
        public void StopMachine(Machine machine)
        {
            machine .IsOnline = false;
            //Machines.Remove(machine);
        }
        
        public static  void UpdateMachineData(int machineId,string data)
        {
            var machine = Machines.FirstOrDefault(m => m.Id == machineId);
            if (machine != null)
            {
                machine.LastUpdated = DateTime.Now;
                machine.LatestData = data;
            }
            LastUpdatedMachine = machine!;
            
        }
        public static int MachinesOnline => Machines.Count(m => m.IsOnline==true);
        public static int TotalMachines => Machines.Count;
       // public Machine LastEditedMachine=>
            


        //public static List<Machine> GetMachines()
        //{
        //    var machines = new List<Machine>
        //    {
        //     new Machine { Id = 1, Name = "Machine A", IsOnline = true, LastUpdated = DateTime.Now.AddMinutes(-30),LatestData="Data1" },
        //     new Machine { Id = 2, Name = "Machine B", IsOnline = false, LastUpdated = DateTime.Now.AddHours(-2),LatestData="Data2" }
        //    };

        //    return machines;
        //}
        //public static Machine? GetMachine(int machineId)
        //{
        //    var machine = GetMachines().FirstOrDefault(m => m.Id == machineId);
        //    return machine;
        //}
    }
}
