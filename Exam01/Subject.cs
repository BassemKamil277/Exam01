using Exam01.Exam;
using Exam01.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    internal class Subject
    {
        #region Attributes
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        BaseClassExam? exam { get; set; }

        #endregion


        #region Methods
        public void createExam()
        {
            int answer, time, number , type , rightId;
            string? body, head;
            decimal mark;
            char C;
                Console.WriteLine("Please enter the type of Exam : (1 for practical | 2 for final)");
            while (!int.TryParse(Console.ReadLine(), out  answer) || (answer < 1 || answer > 2))
            {
                Console.WriteLine("invallid input please enter 1 or 2");
                continue;   
            }
            Console.WriteLine("Please enter the time of exam (30 min to 180 min)");
            while(!int.TryParse(Console.ReadLine(), out time) || (time <= 30 || time > 180))
            {
                Console.WriteLine("invallid time");
                continue;
            }
            Console.WriteLine("Please enter the number of question ");
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 )
            {
                Console.WriteLine("invallid number");
                continue;
            }
            Console.Clear();

               exam = answer == 1 ? new PracticalExam(time, number) : new FinalExam(time, number);

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("Please enter the type of question (1 for MCQ | 2 for True or False) ");
                while (!int.TryParse(Console.ReadLine(), out type) || (type < 1 || type > 2))
                {
                    Console.WriteLine("invallid type number");
                    continue;
                }
                Console.Clear();

                if (type == 1 && (answer == 1 || answer == 2))
                {
                        Console.WriteLine("MCQ question");
                    while (true)
                    {
                        Console.WriteLine("please enter question Head");
                        head = Console.ReadLine();
                        if (head is null || head == "")
                        {
                            Console.WriteLine("invalid head");
                            continue;
                        }
                        break;
                    }


                    while (true)
                    {
                        Console.WriteLine("please enter question body");
                        body = Console.ReadLine();
                        if (body is null || body == "")
                        {
                            Console.WriteLine("invalid body");
                            continue;
                        }
                        break;
                    }

                    Console.WriteLine("please enter question mark");
                    while (!(decimal.TryParse(Console.ReadLine(), out mark) || mark < 0))
                    {
                        Console.WriteLine("mark must be a number bigger than 0");
                        continue;
                    }
                    Console.Clear();

                    Answer[] answers = new Answer[4];
                    Console.WriteLine("Choices of Question");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine($"Please enter choices number {j + 1}");
                        answers[j] = new Answer(j + 1, Console.ReadLine());

                    }
                    Console.WriteLine("please enter the right answer id");
                    while (!(int.TryParse(Console.ReadLine(), out rightId) || (rightId < 1 || rightId > 4)))
                    {
                        Console.WriteLine("invalid id");
                        continue;
                    }
                    Answer rightAnswer = answers[rightId - 1];

                    MCQ MCQ = new MCQ(head, body, mark, answers, rightAnswer);
                    exam.Questions[i] = MCQ;
                }

                else if (answer == 2 && type == 2)
                {
                    Console.WriteLine("True | False Question");
                    while (true)
                    {
                        Console.WriteLine("please enter question Head");
                        head = Console.ReadLine();
                        if (head is null || head == "")
                        {
                            Console.WriteLine("invalid head");
                            continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.WriteLine("please enter question body");
                        body = Console.ReadLine();
                        if (body is null || body == "")
                        {
                            Console.WriteLine("invalid body");
                            continue;
                        }
                        break;
                    }

                    Console.WriteLine("please enter question mark");
                    while (!(decimal.TryParse(Console.ReadLine(), out mark) || mark < 0))
                    {
                        Console.WriteLine("mark must be a number bigger than 0");
                        continue;
                    }

                    Console.WriteLine("please inter the right answer id (1 for true | 2 for false)");
                    while (!int.TryParse(Console.ReadLine(), out rightId) || rightId < 1 || rightId > 2)
                    {
                        Console.WriteLine("invalid Id");
                        continue;
                    }
                    Answer[] TOF = new Answer[]
                    {
                        new Answer(1 , "true"),
                        new Answer (2 , "false"),
                    };

                    Answer RightTOF = TOF[rightId - 1];

                    TrueOrFalse trueOrFalse = new TrueOrFalse(head, body, mark, TOF, RightTOF);
                    exam.Questions[i] = trueOrFalse;

                }
                else if (answer == 1 && type == 2)
                {
                    Console.WriteLine("Not valid type of exam");
                    return;
                }

                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Do you want to start exam : (Y | N)");
            while (!(Char.TryParse(Console.ReadLine(), out C) || (C == 'Y' || C == 'N' || C == 'y' || C == 'n')))
            {
                Console.WriteLine("Your choice must be (Y or N)");
                continue;
            }
            C = char.ToLower(C);
            if (C == 'y')
            {
                Console.Clear ();
                exam.ShowExam();
               
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Closing");
            }

        } 
        #endregion

    }
}
