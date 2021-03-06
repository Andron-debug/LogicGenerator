using System;

namespace Logic
{
    public class LogicEq
    {
        private static string or = "⋁";
        public static string Or
        {
            get
            {
                return or;
            }
            set
            {
                if (value == "") throw new Exception("Значение ИЛИ пусто");
                if ((value != and) && (value != not) && (value != xor)) or = value;
                else throw new Exception("Значение ИЛИ не уникально");
            }
        }
        private static string and = "⋀";
        public static string And
        {
            get
            {
                return and;
            }
            set
            {
                if (value == "") throw new Exception("Значение И пусто");
                if ((value != or) && (value != not) && (value != xor)) and = value;
                else throw new Exception("Значение И не уникально");
            }
        }

        private static string not = "¬";
        public static string Not
        {
            get
            {
                return not;
            }
            set
            {
                if(value == "") throw new Exception("Значение НЕ пусто");
                if ((value != or) && (value != and) && (value != xor)) not = value;
                else throw new Exception("Значение НЕ не уникально");
            }
        }


        private static string xor = "⊕";
        public static string Xor
        {
            get
            {
                return xor;
            }
            set
            {
                if (value == "") throw new Exception("Значение XOR пусто");
                if ((value != or) && (value != not) && (value != and)) xor = value;
                else throw new Exception("Значение XOR не уникально");
            }
        }

        private static string non = "Невозможно построить";
        public static string Non => non;

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
            string result = non;
            int last_index = -1;
            for (int i = 0; i < values.Length; i++)
                if (values[i]) last_index = i;
            if (last_index == -1) return result;
            for (int i = 0; i <= last_index; i++)
            {
                if (values[i])
                {
                    if (result == non) result = "";
                    bool[] row = create_row(i);
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
                    else break;
                }
            }
            return result;
        }
        public string ToPCF()//СКНФ
        {
            string result = non;
            int last_index = -1;
            for (int i = 0; i < values.Length; i++)
                if (!values[i]) last_index = i;
            if (last_index == -1) return result;
            for (int i = 0; i <= last_index; i++)
            {
                if (!values[i])
                {
                    if (result == non) result = "";
                    bool[] row = create_row(i);
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
                    else break;
                }
            }
            return result;
        }
        public string ToPolinom()//Полином Жегалкина
        {
            string result = "1" + xor + "1";

            int true_count = 0;
            for (int i = 0; i < values.Length; i++)
                if (values[i]) true_count++;
            if (true_count == 0) return result;
            if (true_count == values.Length) return "1";

            //Треугольник Паскаля 
            bool[][] pascal = new bool[values.Length][];
            pascal[0] = values;
            int last_index = -1;
            for (int i = 0; i < values.Length - 1; i++)
            {
                bool[] row = pascal[i];
                bool[] next_row = new bool[row.Length - 1];
                for (int j = 0; j < row.Length - 1; j++)
                    next_row[j] = doxor(row[j], row[j + 1]);
                if (next_row[0]) last_index = i + 1;
                pascal[i + 1] = next_row;
            }

            if (pascal[0][0]) result = "1";
            else result = "";

            if (last_index == 0) return result;
            else if (pascal[0][0]) result += xor;

            for (int i = 1; i < values.Length; i++)
            {
                if (pascal[i][0])
                {
                    bool[] row = create_row(i);
                    string blok = "(";
                    int last_j = -1;
                    for (int j = 0; j < row.Length; j++)
                        if (row[j]) last_j = j;
                    for (int j = 0; j < row.Length; j++)
                    {
                        if (row[j])
                        {
                            blok += var_names[j];
                            if (j != last_j) blok += and;
                            else break;
                        }
                    }
                    blok += ")";
                    result += blok;
                    if (i != last_index) result += xor;
                    else break;
                }
            }
            return result;
        }
        public string Dual()
        {
            bool dual = true;
            bool[] dual_val = new bool[values.Length];
            for(int i = 0; i < values.Length; i++)
            {
                dual_val[values.Length - 1 - i] = !values[i];
                if (!doxor(values[i], values[values.Length - 1 - i])) dual = false;
            }
            if (dual) return "Функция самодвойственна";
            return new LogicEq(dual_val, var_names).ShortestForm();
        }
        public string ShortestForm()
        {
            string pdf = ToPDF();
            string pcf = ToPCF();
            string polinom = ToPolinom();
            if ((pdf.Length <= pcf.Length) && (pdf.Length <= polinom.Length)&&(pdf != non)) return pdf;
            if ((pcf.Length <= polinom.Length) && (pcf.Length <= pdf.Length)&&(pcf!=non)) return pcf;
            return polinom;
        }

        public bool[] create_row(int n) => create_row(n, var_names.Length);

        public static bool[] create_row(int n, int var_count)
        {
            bool[] result = new bool[var_count];
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

        private bool doxor(bool a, bool b) => (!a || !b) && (a || b);

    }
}
