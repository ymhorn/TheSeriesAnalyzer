[1mdiff --git a/TheSeriesAnalyzer/Program.cs b/TheSeriesAnalyzer/Program.cs[m
[1mindex 6d741db..33e22d8 100644[m
[1m--- a/TheSeriesAnalyzer/Program.cs[m
[1m+++ b/TheSeriesAnalyzer/Program.cs[m
[36m@@ -24,35 +24,36 @@[m [mnamespace TheSeriesAnalyzer[m
         {[m
             Console.WriteLine(toPrint);[m
         }[m
[31m-        static void DisplaySeries(List<int>series)[m
[32m+[m[32m        static void DisplaySeries(int[] series)[m
         {[m
[31m-[m
[32m+[m[41m            [m
         }[m
[31m-        static void DisplayInOrder(List<int>series)[m
[32m+[m[32m        static void DisplayInOrder(int[] series)[m
         {[m
[32m+[m[41m            [m
 [m
         }[m
[31m-        static void DisplayInOppositeOrder(List<int>series)[m
[32m+[m[32m        static void DisplayInOppositeOrder(int[] series)[m
         {[m
 [m
         }[m
[31m-        static void MaxInSeries(List<int>series)[m
[32m+[m[32m        static void MaxInSeries(int[] series)[m
         {[m
 [m
         }[m
[31m-        static void MinInSeries(List<int> series)[m
[32m+[m[32m        static void MinInSeries(int[] series)[m
         {[m
 [m
         }[m
[31m-        static void AverageInSeries(List<int> series)[m
[32m+[m[32m        static void AverageInSeries(int[] series)[m
         {[m
 [m
         }[m
[31m-        static void SumOfSeries(List<int> series)[m
[32m+[m[32m        static void SumOfSeries(int[] series)[m
         {[m
 [m
         }[m
[31m-        static void LengthOfSeries(List<int> series)[m
[32m+[m[32m        static void LengthOfSeries(int[] series)[m
         {[m
 [m
         }[m
