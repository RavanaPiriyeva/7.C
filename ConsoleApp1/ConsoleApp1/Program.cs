using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            for (int i = 0; i < 1; i++)
            {
                
                string no ;
                int studentlimit;
              
                    Console.WriteLine("No deyerini daxil edin:");
                    no = Console.ReadLine();
                for (int j = 2; j < 4; j++)
                {
                    while (char.IsUpper(no[0])==false  || char.IsUpper(no[1])==false || char.IsDigit(no[j]) == false || no.Length>5)
                    {
                        Console.WriteLine("NO deyerini duzgun daxil edin!!!!");
                        no=Console.ReadLine();
                    }

                }

                do
                {
                  
                    Console.WriteLine("Sagird sayini daxil edin :");
                    studentlimit = Convert.ToInt32(Console.ReadLine());
                    if (studentlimit <= 0 || studentlimit > 20)
                    {
                        Console.WriteLine("Sagird sayin duzgun daxil et!!!");
                    }
                }
                while ( studentlimit<=0 || studentlimit>20);
                Group group = new Group( no ,studentlimit);
              
                bool y = true;
                int m = 1;
                group.Students = new Student[studentlimit];
                while (y) {
                    
                Console.WriteLine(" \n1.Telebe elave et"); 
                Console.WriteLine("2.Butun telebelere bax"); 
                Console.WriteLine("3.Telebeler uzre axtarış et"); 
                Console.WriteLine("0.Proqramı bitir"); 
                
                int choice = Convert.ToInt32(Console.ReadLine());
               
                    switch (choice)

                {
                   case 1:
                            Console.WriteLine("Nece sagird daxil edirsiniz ?");
                           int x = Convert.ToInt32(Console.ReadLine());
                           
                           
                            for (int j = 0; j < x; j++)
                            {
                                if (m <= studentlimit)
                                {

                                    Console.WriteLine(m+".Ad ve soyad daxil edin:");
                            string fullname = Console.ReadLine();
                            Console.WriteLine(m + ".Group nomresini daxil edin:");
                            int groupno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(m + ".Ortalama bali daxil edin :");
                            int avgpoint = Convert.ToInt32(Console.ReadLine());
                          

                            group.AddStudent(new Student(fullname, groupno, avgpoint) );
                                    m++;
                                }
                               
                            }   

                   
                    
                    break;
                    
                        case 2:
                        Console.WriteLine(2);
                            group.GetInfo(group.Students);
                     
                        break;
                        case 3:
                        Console.WriteLine(3);
                            
                            bool n = true;
                            while (n)
                            {
                                Console.WriteLine("Filter Olunsun ? :  y / n ");
                                char answer = Convert.ToChar(Console.ReadLine());
                                if (answer == 'y')
                                {
                                    while (true)
                                    {
                                        Console.WriteLine(" 1- Ada gore , 2- Qrup nomresine gore  , 3-bala gore  1 / 2 /3 ");
                                        answer = Convert.ToChar(Console.ReadLine());
                                        if (answer == '1')
                                        {
                                            
                                            Console.WriteLine("Axtarilacaq adi daxil edin .");
                                            string name = Console.ReadLine();
                                            group.GetInfo(group.GetFiltired(name));
                                            n = false;
                                            break;
                                        }

                                        else if (answer == '2')
                                        {
                                            Console.WriteLine("Hansi qrup axtarilsin . ");
                                            int groupno = Convert.ToInt32(Console.ReadLine());
                                            
                                            group.GetInfo(group.GelFilteredGroup(groupno));
                                            n = false;
                                            break;
                                        }
                                        else if (answer == '3')
                                        {
                                            Console.WriteLine("Hansi qiymet intervalinda axtarilirsa , hemin qiymtleri daxil edin . ");
                                            int minprice = Convert.ToInt32(Console.ReadLine());
                                            int maxprice = Convert.ToInt32(Console.ReadLine());
                                            group.GetInfo(group.GelFilteredPoint(minprice, maxprice));
                                            n = false;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Duzgun deyer daxil edin !!!");
                                        }

                                    }

                                }
                                else if (answer == 'n')
                                    {
                                    group.GetInfo(group.Students);
                                    n = false;
                                }
                                else
                                {
                                    Console.WriteLine("Duzgun deyer daxil edin:");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("duzgun daxil et");
                            break;
                        case 0:
                        Console.WriteLine(0);
                        y = false;

                            return;
                        
                    }
                   

                }

            }
        }
    }
}
