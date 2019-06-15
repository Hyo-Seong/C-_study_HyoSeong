using FishMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMarket
{
    public class Main
    {
        List<Fish> fishList = new List<Fish>();
        public void MainDialog()
        {
            Console.WriteLine("1. 물고기 등록 || 2. 물고기 구매 || 3.프로그램 종료");
            string read = Console.ReadLine();

            switch (read)
            {
                case "1":
                    RegisterFish();
                    break;
                case "2":
                    BuyFish();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("잘못된 값을 입력하셨습니다.\n다시 입력해 주세요.");
                    MainDialog();
                    break;
            }
        }

        private void BuyFish()
        {
            Console.Clear();

            Fish fish = GetFish(true);

            Console.Clear();

            if (fish != null)
            {
                if (CheckValidFish(fish.Name))
                {
                    Console.WriteLine("존재하지 않는 물고기입니다.");
                    MainDialog();
                } else if (CheckQuantity(fish))
                {
                    Console.WriteLine("수량이 부족합니다.");
                    MainDialog();
                }
                else if (CheckPrice(fish))
                {
                    fishList.Single(x => x.Name == fish.Name).Quantity -= fish.Quantity;
                    Console.WriteLine($"[{fish.Name}] {fish.Quantity}마리 구매완료");
                }
                else
                {
                    Console.WriteLine("돈이 부족합니다");
                }
                MainDialog();
            }

        }

        /// <summary>
        /// 부족하면 true, 아니면 false
        /// </summary>
        /// <param name="fish"></param>
        /// <returns></returns>
        private bool CheckQuantity(Fish fish)
        {
            Fish fish2 = fishList.Find(x => x.Name == fish.Name);
            if(fish2 != null)
            {
                if(fish2.Quantity < fish.Quantity)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckPrice(Fish fish)
        {
            Fish fish2 = fishList.Find(x => x.Name == fish.Name);
            if(fish2 != null)
            {
                if (fish2.Price * fish.Quantity > fish.Price)
                {
                    return false;
                }
            }
            return true;
        }

        private void RegisterFish()
        {
            Fish fish = new Fish();
            Console.Clear();

            fish = GetFish(true);

            Console.Clear();
            if(fish != null)
            {
                if (CheckValidFish(fish.Name))
                {
                    fishList.Add(fish);
                
                    Console.WriteLine("물고기 등록 성공.");
                } else
                {
                    Console.WriteLine("이미 등록된 물고기입니다.");
                }
                MainDialog();
            }
        }

        private Fish GetFish(bool isBuy)
        {
            Fish fish = new Fish();
            string temp = string.Empty;
            if (isBuy)
            {
                temp = "구매할 ";
            }
            try
            {
                Console.Write(temp + "물고기 이름 입력 >> ");
                fish.Name = Console.ReadLine();
                Console.Write(temp + "물고기 가격 입력 >> ");
                fish.Price = Int32.Parse(Console.ReadLine());
                Console.Write(temp + "물고기 수량 입력 >> ");
                fish.Quantity = Int32.Parse(Console.ReadLine());

                return fish;
            }
            catch (Exception e)
            {
                Console.WriteLine("숫자를 입력주세요.");
                GetFish(isBuy);
            }
            return null;
        }
        
        private bool CheckValidFish(string name)
        {
            if(fishList.Find(x => x.Name == name) == null)
            {
                return true;
            }
            return false;
        }
    }
}
