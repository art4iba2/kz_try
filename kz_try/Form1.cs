using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kz_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class first
        {
            public DateTime date1;
            public DateTime date2;
            public string string1;
            public decimal dec1;

            public class second
            {
                public DateTime date3;
                public DateTime date4;
                public int int1;
                public static ArrayList Result;
                /*
                public static ArrayList arrayList()
                {
                    ArrayList data = new ArrayList();
                    data.Add(new second { date3 = DateTime.Parse("4/4/2022"), date4 = DateTime.Parse("5/5/3033"), int1 = 13 });
                    return data;

                }
                */
                public class third : second
                {
                    public DateTime date5;
                    public int int2;
                    public static ArrayList thirdarray()
                    {
                        ArrayList data2 = new ArrayList();
                        data2.Add(new third { date3 = DateTime.Parse("4/4/2022"), date4 = DateTime.Parse("5/5/3033"), int1 = 13 , date5 = DateTime.Parse("4/4/2032"), int2 = 12 });
                        return data2;
                    }
                }
                static second()
                {
                    Result = third.thirdarray();

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var f = first.second.Result
                .OfType<first.second.third>()
                
                .Select(x => x.int1 );

            foreach (var r in f)
            {
                label1.Text +=" " + Convert.ToString(r);
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}