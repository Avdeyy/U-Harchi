using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба1
{
    public class Food
    {
        public bool Carbohydrate { get; set; }
        public bool Fat { get; set; }
        public bool Protein { get; set; }
        public string? Name { set; get; }
        public int Colvo { set; get; }
    }

    public interface ISemiFifinishedFood
    {

    }

    public interface ISnacks
    {

    }

    public interface IHealthyFood
    {

    }

    public class ChocoBar : Food, ISnacks
    {
        
    }

    public class Crisps : Food, ISnacks
    {
        
    }

    public class BalykCheese : Food, ISnacks
    {
        
    }

    public class Chicken : Food, IHealthyFood
    {
        
    }

    public class OliveOil : Food, IHealthyFood
    {
        
    }

    public class Fruit : Food, IHealthyFood
    {
        
    }

    public class Cheburec : Food, ISemiFifinishedFood
    {
        
    }

    public class DumplingsMeat : Food, ISemiFifinishedFood
    {
        
    }

    public class DumplingsBerries : Food, ISemiFifinishedFood
    {
        
    }
}
