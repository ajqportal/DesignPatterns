using DesignPattern.Structural.Facade.Subsystems;

namespace DesignPattern.Structural.Facade.Facades
{
    internal class ComputerFacade
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hardDrive;

        public ComputerFacade()
        {
            cpu = new CPU();
            memory = new Memory();
            hardDrive = new HardDrive();
        }

        public void Start()
        {
            cpu.Freeze();
            memory.Load(0, hardDrive.Read(0, 1024));
            cpu.Jump(0);
            cpu.Execute();
        }
    }
}
