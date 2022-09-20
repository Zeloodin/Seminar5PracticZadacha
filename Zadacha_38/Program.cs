using System;
using Microsoft.CodeAnalysis.CSharp.Scripting;

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Вещественные числа — это числа, у которых есть дробная часть (она может быть нулевой).
// Они могут быть положительными или отрицательными.
// Примеры: 15, 56.22, 0.0, -232336.11

// enum Comparison_Operators
// {
//     =
//     >
//     >=
//     <
//     <=
// }



// double ForDouble(string AssignmentToAVariableI, string ILessThanLength, string ActionWithVariableI) // for to while eval or exec
// {
//     string i = CSharpScript.EvaluateAsync(AssignmentToAVariableI);
    
//     return 0;
// }








//     for      (int    i = 0; i      <                           length;        i++)
double ForDouble(double i, string ComparisonOperators, double lenght, string script)
{
    double firstNum = i;
    double lenghtNum = lenght;
    string strComprOprtr = ComparisonOperators;
    string scriptFirst = script;
    bool CompOper = true;
    while(CompOper)
    {
        switch (strComprOprtr)
        {
        case "==":
            CompOper = (firstNum == lenghtNum);
            break;

        case ">":
            CompOper = (firstNum > lenghtNum);
            break;

        case ">=":
            CompOper = (firstNum >= lenghtNum);
            break;

        case "<":
            CompOper = (firstNum < lenghtNum);
            break;

        case "<=":
            CompOper = (firstNum <= lenghtNum);
            break;
        default:
            break;
        }
        CompOper = false;
    }
    CSharpScript.EvaluateAsync(scriptFirst);


    Console.WriteLine(firstNum);
    return firstNum;
}





ForDouble(0, "<=", 1, "firstNum++");

// double[] ArrayGeneratorNumber(double count, double min, double max)
// {
//     double[] arrayList = new double[count];
//     for (double i = 0; i < count; i++)
//        arrayList[i] = new Random().Next(min, max);
//     return arrayList;
// }

// double[] arrayList = ArrayGeneratorNumber(10, -100, 101);

// double countSumChetnihChisel = 0;
// double tempNumberI = 0;


















// for (double i = 0; i < arrayList.Length; i++)
//     if(i % 2 == 1) countSumChetnihChisel += arrayList[i];
        

// Console.Write("[");
// for (double n = 0; n < arrayList.Length; n++)
// {
//     if(n < arrayList.Length - 1)
//         Console.Write($"{arrayList[n]}, ");
//     else
//         Console.Write($"{arrayList[n]}");
// }
// Console.WriteLine($"] -> Сумма чисел на нечётных позициях: {countSumChetnihChisel}");
