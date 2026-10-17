using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaobabRidge
{
    class SummaryReport
    {


        

            private readonly string reportPath =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "summary.txt");

            // Calculates the report and saves it to summary.txt.
            public string GenerateReport(List<Animal> animals)
            {
                int total = animals.Count;

                string averageAge = total == 0
                    ? "N/A"
                    : animals.Average(a => a.Age).ToString(
                        "F2", CultureInfo.InvariantCulture);

                string averageScore = total == 0
                    ? "N/A"
                    : animals.Average(a => a.RecoveryScore).ToString(
                        "F2", CultureInfo.InvariantCulture);

                string[] statuses =
                {
                "Critical",
                "Serious",
                "Stable",
                "Recovering",
                "Release-Ready"
            };

                StringBuilder report = new StringBuilder();

                report.AppendLine(
                    "BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                report.AppendLine("ANIMAL SUMMARY REPORT");

                report.AppendLine(
                    "Generated: " +
                    DateTime.Now.ToString(
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture));

                report.AppendLine(
                    "----------------------------------------");

                report.AppendLine(
                    $"Total animals:            {total}");
                report.AppendLine(
                    $"Average age (years):      {averageAge}");
                report.AppendLine(
                    $"Average recovery score:   {averageScore}");

                report.AppendLine(
                    "----------------------------------------");
                report.AppendLine("Animals per status:");

                foreach (string status in statuses)
                {
                    int count = animals.Count(
                        a => a.Status == status);

                    report.AppendLine(
                        $"{status + ":",-26}{count}");
                }

                string reportText = report.ToString();

                File.WriteAllText(
                    reportPath,
                    reportText,
                    new UTF8Encoding(false));

                return reportText;
            }
        }
    }








