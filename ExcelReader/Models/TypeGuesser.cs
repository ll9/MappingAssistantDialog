using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReader.Models
{
    class TypeGuesser
    {
        public static DataType GuessType(DataTable dataTable, string columnName)
        {
            foreach (var type in Enum.GetValues(typeof(DataType)).Cast<DataType>())
            {
                int i;
                for (i = 0; i < dataTable.Rows.Count; i++)
                {
                    //var value = values[i];
                    var value = dataTable.Rows[i][columnName].ToString();
                    if (GuessType(value) != type)
                    {
                        break;
                    }
                }
                if (i == dataTable.Rows.Count)
                    return type;
            }
            return DataType.System_String;
        }

        private static DataType GuessType(string str)
        {

            bool boolValue;
            Int32 intValue;
            Int64 bigintValue;
            double doubleValue;
            DateTime dateValue;

            // Place checks higher in if-else statement to give higher priority to type.

            if (bool.TryParse(str, out boolValue))
                return DataType.System_Boolean;
            else if (Int32.TryParse(str, out intValue))
                return DataType.System_Int32;
            else if (Int64.TryParse(str, out bigintValue))
                return DataType.System_Int64;
            else if (double.TryParse(str, out doubleValue))
                return DataType.System_Double;
            else if (DateTime.TryParse(str, out dateValue))
                return DataType.System_DateTime;
            else return DataType.System_String;

        }
    }
}
