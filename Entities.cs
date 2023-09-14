using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialPj {
    internal class Entities {

        public int N { get; set; }
        

        public Entities(int n) {

            N = n;

        }

        public int Fatorial(int n) {

            int sum = 1;

            for (int i = 1; i <= N; i++) {


                sum += sum * (n - i);
                
            }
            return sum;
        
        }

        public override string ToString() {
            return Fatorial(N).ToString();
        }
    }
}
