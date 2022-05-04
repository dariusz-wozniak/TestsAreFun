using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ExcelDataReader;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace TestsAreFun.Tests.Integration.ParametrizedTests;

public class Log2NData
{
    private static DataTable ReadExcelData()
    {
        // https://stackoverflow.com/questions/50858209/system-notsupportedexception-no-data-is-available-for-encoding-1252:
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ParametrizedTests", "Log2N.xlsx");
        using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
        using var reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            
        var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
        {
            ConfigureDataTable = _ => new ExcelDataTableConfiguration
            {
                UseHeaderRow = true
            }
        });
        return dataSet.Tables[0];
    }

    internal static IEnumerable<ITestCaseData> Data
    {
        get
        {
            DataTable results = ReadExcelData();
            if (results == null) throw new InvalidOperationException("Well, something went wrong and results is null");

            foreach (DataRow row in results.Rows)
            {
                double a = Convert.ToDouble(row["n"]);
                double result = Convert.ToDouble(row["log2(n)"]);
                yield return new TestCaseData(a, result);
            }
        }
    }
}