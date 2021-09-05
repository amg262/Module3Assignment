﻿using System;

namespace Module3Assignment
{
    class Program
    {
        static double Steps(double steps)
        {
            double totalPoints = 0;

            if (steps >= 1)
            {
                totalPoints = steps * 5;
            }
            else
            {
                totalPoints = 0;
            }

            return totalPoints;
        }
        
        static double Yoga(double classes)
        {
            double totalPoints = 0;

            if (classes >= 6 || classes <= 11)
            {
                totalPoints += classes * 10;
            } else if (classes >= 12)
            {
                totalPoints += classes * 30;
            }
            else
            {
                totalPoints = 0;
            }
            return totalPoints;
        }
        
        static double Aerobics(double classes)
        {
            double totalPoints = 0;

            if (classes >= 6 || classes <= 11)
            {
                totalPoints += classes * 20;
            } else if (classes >= 12)
            {
                totalPoints += classes * 50;
            }
            else
            {
                totalPoints = 0;
            }
            return totalPoints;
        }
        
        static double Nutrition(double classes)
        {
            double totalPoints = 0;

            if (classes >= 1 || classes <= 3)
            {
                totalPoints += classes * 10;
            } else if (classes == 4)
            {
                totalPoints += classes * 30;
            }
            else if (classes > 4)
            {
                totalPoints = 4 * 30;
            }
            else
            {
                totalPoints = 0;
            }
            return totalPoints;
        }
        
        

        static void Main(string[] args)
        {

            double tenThouSteps = 0;
            double yogaClasses = 0;
            double aerobicsClasses = 0;
            double weeklyNutrition = 0;
            double monthlyPoints = 0;
            double giftCardsEarned = 0;

            Console.WriteLine("Number of days with at least 10,000 steps>");
            Double.TryParse(Console.ReadLine(), out tenThouSteps);
            Console.WriteLine("Number of yoga classes attended>");
            Double.TryParse(Console.ReadLine(), out yogaClasses);
            Console.WriteLine("Number of aerobics classes attended>");
            Double.TryParse(Console.ReadLine(), out aerobicsClasses);
            Console.WriteLine("Number of weekly nutrition meetings attended>");
            Double.TryParse(Console.ReadLine(), out weeklyNutrition);


            monthlyPoints += Steps(tenThouSteps);
            monthlyPoints += Yoga(yogaClasses);
            monthlyPoints += Aerobics(aerobicsClasses);
            monthlyPoints += Nutrition(weeklyNutrition);

            giftCardsEarned = monthlyPoints / 50;

            Console.WriteLine($"{tenThouSteps} 10k step days > Pts: {monthlyPoints} > Cards: {giftCardsEarned}");
            Console.WriteLine($"{yogaClasses} yoga classes > Pts: {monthlyPoints} > Cards: {giftCardsEarned}");
            Console.WriteLine($"{aerobicsClasses} aerobics classes > Pts: {monthlyPoints} > Cards: {giftCardsEarned}");
            Console.WriteLine($"{weeklyNutrition} meetings > Pts: {monthlyPoints} > Cards: {giftCardsEarned}");
            
            




        }
    }
}