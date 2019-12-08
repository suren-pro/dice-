using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    
    class Dice
    {

        public delegate void EventHandler();

        public event EventHandler ForTwoTimes =null;
        public event EventHandler SumTrigger=null;


        public void Show()
        {

            this.ForTwoTimes?.Invoke();

        }

     


        Random random = new Random();

        public void ShowFour()
        {
            Console.WriteLine("Two fours in a row");
            
        }
        public void Sum()
        {
            Console.WriteLine("The sum of numbers is satisfied condition ");

        }
        public Dice()
        {
            ForTwoTimes += ShowFour;
            SumTrigger += Sum;
        }
        public void Roll()
        {
            int side, sum = 0,counter=0;
            int[] dice = new int[5];
            

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = random.Next(1, 7);
                sum += dice[i];

            }
            
            for (int i = 0; i < dice.Length-1; i++)
            {
                if (dice[i] == 4 && dice[i + 1] == 4)
                    counter++;
                
            }
            if (counter >= 1)
            {
               
                ForTwoTimes?.Invoke();

            }

            if(sum >= 20)
            {
                SumTrigger?.Invoke();
            }

            foreach (var item in dice)
            {
                Console.Write(item+" ");

            }
         

            Console.WriteLine();
            
        }

    }
}
