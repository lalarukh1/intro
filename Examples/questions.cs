
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    public class Program12
    {
        List<Questions> questlist = new List<Questions>();
        public Program12()
        {
            data();
            print();
        }

        
        struct Questions
        {
            public String Questionn;
            public String Answer;
            //public String Answer1;
        }

        void data()
        {
            Questions question = new Questions();
            question.Questionn = "What is your name";
            question.Answer = "Lala Rukh";
            questlist.Add(question);

            Questions question1 = new Questions();
            question1.Questionn = "What's up?";
            question1.Answer = "Studying";
            questlist.Add(question1);

            Questions question2 = new Questions();
            question2.Questionn = "How would you prepare for interview";
            question2.Answer = "Through this program";
            questlist.Add(question2);
        }

        void print()
        {
            while (questlist.Count != 0)
            {
                Random random = new Random();
                int rand = random.Next(0, questlist.Count);

                Console.WriteLine(questlist[rand].Questionn);
                Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(questlist[rand].Answer);
                Console.WriteLine("\nDid you get this correct?");
                Console.WriteLine("  y for Yes    n for No");


                while (true)
                {
                    Char correct = Console.ReadKey().KeyChar;
                    if (correct == 'n')
                    {
                        break;
                    }
                    else if (correct == 'y')
                    {
                        questlist.Remove(questlist[rand]);
                        break;
                    }
                }
                    Console.Clear();
            }
                Console.WriteLine("Well Done you have got all Answers right!!");
            Console.ReadKey();
        }
        


    }
}
