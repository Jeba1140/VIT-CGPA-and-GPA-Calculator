using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPACalculatorClass
{
    public class CgpaCalculator : MarshalByRefObject
    {
        double total,sum,cgpa,cgpa2,gpa,gpa2;
        public CgpaCalculator()
        { 
           
        }
        public double calcgpa1(double g1, double g2, double g3, double g4, double g5, double g6, double g7, double g8, int c1, int c2, int c3, int c4, int c5, int c6, int c7, int c8)
        {
            total = (g1 * c1 + g2 * c2 + g3 * c3 + g4 * c4 + g5 * c5 + g6 * c6 + g7 * c7 + g8 * c8);
            sum = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8;
            cgpa = total / sum;
            cgpa2 = Math.Round(cgpa, 2);
            return cgpa2;
        }
        public double calcgpa2(int c1, double g1, int c2, double g2)
        {
            total = (c1 * g1 + c2 * g2);
            sum = c1 + c2;
            cgpa = total / sum;
            cgpa2 = Math.Round(cgpa,2);
            return cgpa2;
        }
        public double calgpa(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int c1, int c2, int c3, int c4, int c5, int c6, int c7, int c8, int c9, int c10)
        {
            total = (p1 * c1 + p2 * c2 + p3 * c3 + p4 * c4 + p5 * c5 + p6 * c6 + p7 * c7 + p8 * c8 + p9 * c9 + p10 * c10);
            sum = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10;
            gpa = total / sum;
            gpa2 = Math.Round(gpa, 2);
            return gpa2;
        }
    }
}
