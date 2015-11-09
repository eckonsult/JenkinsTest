using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec.JenkinsTest {
    public class Complex {
        public int R { get; set; }
        public int I { get; set; }

        public static Complex operator +(Complex a, Complex b)
        {
          return new Complex {R = a.R + b.R, I = a.I + b.I};
        }

        public static Complex operator -(Complex a, Complex b) {
            return new Complex { R = a.R - b.R, I = a.I + b.I };
        }

    }
}
