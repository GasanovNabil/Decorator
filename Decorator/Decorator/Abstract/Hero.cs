namespace Decorator
{
    abstract class Hero // Абстрактный класс от которого будут наследоваться классы Human and Elf
    {
        public string ParentClass { get; set; }
        public uint Attack { get; set; }
        public uint Speed { get; set; }
        public uint Health { get; set; }
        public uint Defence { get; set; }

        public uint Level { get; set; }

        abstract public void Move();
        abstract public void Show();
    }
}
