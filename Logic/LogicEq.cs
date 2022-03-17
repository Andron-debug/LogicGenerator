using System;

namespace Logic
{
    public class LogicEq
    {
        public static string or = "⋁";
        public static string and = "⋀";
        public static string not = "¬";
        public static string xor = "⊕";

        private bool[] values;
        private string[] var_names;
        public bool[] Values => values;
        public LogicEq(bool[] val, string[] var_n)
        {
            if (var_n.Length != (int)Math.Log(val.Length, 2)) throw new Exception("Wrong number of variables");
            values = val;
            var_names = var_n;
        }
        public string ToPDF() //СДНФ
        {
            string result = "0";
            int last_index = 0;
            for (int i = 0; i < values.Length; i++)
                if (values[i]) last_index = i;
                for (int i = 0; i <= last_index; i++)
                {
                    if (values[i])
                    {
                        if (result == "0") result = "";
                        bool[] row = create_var_val(i);
                        string blok = "(";
                        for (int j = 0; j < row.Length; j++)
                        {
                            if (!row[j]) blok += not;
                            blok += var_names[j];
                            if (j != row.Length - 1) blok += and;
                        }
                        blok += ")";
                        result += blok;
                        if (i != last_index) result += or;
                    }
                }
            return result;
        }
        public string ToPCF()//СКНФ
        {
            string result = "1";
            int last_index = 0;
            for (int i = 0; i < values.Length; i++)
                if (!values[i]) last_index = i;
            for (int i = 0; i <= last_index; i++)
            {
                if (!values[i])
                {
                    if (result == "1") result = "";
                    bool[] row = create_var_val(i);
                    string blok = "(";
                    for (int j = 0; j < row.Length; j++)
                    {
                        if (row[j]) blok += not;
                        blok += var_names[j];
                        if (j != row.Length - 1) blok += or;
                    }
                    blok += ")";
                    result += blok;
                    if (i != last_index) result += and;
                }
            }
            return result;
        }
        public string ToPolinom()//Полином Жегалкина
        {
            string result = "";
            bool[] r = create_var_val(0);
            return result;
        }
        private bool[] create_var_val(int n)//Строка таблицы истинности
        {
            bool[] result = new bool[var_names.Length];
            int i = result.Length - 1;
            while (n != 0)
            {
                if (n % 2 == 0) result[i] = false;
                else result[i] = true;
                i--;
                n /= 2;
            }
            return result;
        }
        
    }
}
