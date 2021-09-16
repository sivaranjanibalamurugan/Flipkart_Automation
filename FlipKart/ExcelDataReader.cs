﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart
{
    class ExcelDataReader
    {
        public static DataTable ExcelDataTable(string Filename)
        {
            //To Open and Read the data in the file
            FileStream stream = File.Open(Filename, FileMode.Open, FileAccess.Read);
            //To encode the data
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //To read the data from excel sheet 
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            //To create data set from data 
            DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            //Collection of datatable objects for the given dataset
            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;
        }
        public class DataCollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }


        }
        static List<DataCollection> dataCol = new List<DataCollection>();
        public static void PopulateInCollection(string filename)
        {
            DataTable table = ExcelDataTable(filename);
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    dataCol.Add(dtTable);
                }
            }
        }
        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                string data = (from colData in dataCol where colData.colName == columnName && colData.rowNumber == rowNumber select colData.colValue).SingleOrDefault();
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
