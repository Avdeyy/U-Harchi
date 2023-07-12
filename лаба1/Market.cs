using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace лаба1
{
    public class Cart<T> where T : Food
    {
        public List<T>? Foodstuffs { set; get; }
        public List<T>? Things { set; get; }
        public void CartBalansing(List<T> Foodstuffs, List<T> Things, int Id, int Ip, int p, int f, int c)
        {
            if (Id == 1)
            {
                if (p == 0)
                {
                    for (int i = 0; i < Foodstuffs.Count; i++)
                    {
                        if (Foodstuffs[i].Protein)
                        {
                            Things.Add(Foodstuffs[i]);
                            Things[Things .Count - 1].Colvo++;
                            break;
                        }
                    }
                }
                if (f == 0)
                {
                    for (int i = 0; i < Foodstuffs.Count; i++)
                    {
                        if (Foodstuffs[i].Fat)
                        {
                            Things.Add(Foodstuffs[i]);
                            Things[Things.Count - 1].Colvo++;
                            break;
                        }
                    }
                }
                if (c == 0)
                {
                    for (int i = 0; i < Foodstuffs.Count; i++)
                    {
                        if (Foodstuffs[i].Carbohydrate)
                        {
                            Things.Add(Foodstuffs[i]);
                            Things[Things.Count - 1].Colvo++;
                            break;
                        }
                    }
                }
            }
            else if (Id == 2)
            {
                if (Ip == 1)
                {
                    if (p == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Protein && Foodstuffs[i] is ISnacks)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                    if (f == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Fat && Foodstuffs[i] is ISnacks)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                    if (c == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Carbohydrate && Foodstuffs[i] is ISnacks)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                }
                else if (Ip == 2)
                {
                    if (p == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Protein && Foodstuffs[i] is IHealthyFood)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                    if (f == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Fat && Foodstuffs[i] is IHealthyFood)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                    if (c == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Carbohydrate && Foodstuffs[i] is IHealthyFood)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                }
                else if (Ip == 3)
                {
                    if (p == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Protein && Foodstuffs[i] is ISemiFifinishedFood)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                    if (f == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Fat && Foodstuffs[i] is ISemiFifinishedFood)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                    if (c == 0)
                    {
                        for (int i = 0; i < Foodstuffs.Count; i++)
                        {
                            if (Foodstuffs[i].Carbohydrate && Foodstuffs[i] is ISemiFifinishedFood)
                            {
                                Things.Add(Foodstuffs[i]);
                                Things[Things.Count - 1].Colvo++;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
    public class UMarket
    {
        public int Proteins { set; get; }
        public int Fats { set; get; }
        public int Carbohydrates { set; get; }
        public int Id { set; get; }
        public int Ip { set; get; }
    }

    public class Thing
    {
        public string Name { set; get; }
    }
}
