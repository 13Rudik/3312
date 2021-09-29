using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3312.Classes.Entiryes
{
    public class Menedjer
    {
        public int men_id;
        public string fio;
        public int proc;
        public decimal oklad;
        public Menedjer(DataRow row)
        {
            men_id = Convert.ToInt32(row["men_id"]);
            fio = Convert.ToString(row["fio"]);
            proc = Convert.ToInt32(row["proc"]);
            oklad = Convert.ToDecimal(row["oklad"]);
        }

        public Menedjer()
        {
        }

        public static List<Menedjer> Select()
        {
            List<Menedjer> menedjers = new List<Menedjer>();
            foreach(DataRow row in DdConnector.Select("select * from menedjer").Rows)
            {
                menedjers.Add(new Menedjer(row));
            }
            return menedjers;
        }
        public static void Add (string fio, int proc, decimal oklad)
        {
            DdConnector.Select("INSERT INTO `menedjer`(`fio`, `proc`, `oklad`) VALUE ('"+fio+"', '"+proc+"', '"+oklad+"');");
        }
        public void Change(string fio, int proc, decimal oklad)
        {
            DdConnector.Select("UPDATE `menedjer` SET `fio` = '" + fio + "', `proc` = '" + proc + "',`oklad` = '" + oklad + "' WHERE (`men_id` = '"+ men_id +"');");
        }
    }
}
