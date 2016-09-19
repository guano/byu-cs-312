using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class is_prime : Form
    {
        public is_prime()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void solve_Click(object sender, EventArgs e)
        {
            // Load the input, apply our algorithm, and give the output. Simple enough.
            output.Text = input.Text;
            long possible_prime = (Convert.ToInt64(input.Text));
            if (prime_maybe(possible_prime)) {
                double k = Convert.ToDouble(k_value.Text);
                output.Text = "prime! ErrorProb " + 100.0*(1.0/(Math.Pow(2.0, k))) + "%";
            } else {
                output.Text = "Nope, not prime.";
            }
        }

        private void is_prime_Load(object sender, EventArgs e)
        {

        }

        // O(n^3)
        private bool prime_maybe(long n) {
            // pick k positive integers at random that are between 2 and k
            // O(1)
            Random rnd = new Random();
            int test = rnd.Next(2, 12);
            int k = (Convert.ToInt32(k_value.Text));
            int[] rands = new int[k];
            for (int i = 0; i< k; i++){
                rands[i] = rnd.Next(2, (int) n - 1);
            }

            // if(a^(n-1) mod n == 1 for all above numbers)
            // O(1 * O(mod_exp))
            foreach (long r in rands) {
                long exp = mod_exp((int) r, ((int) n - 1), (int) n);
                if (exp != 1) {
                    return false;
                }
            }
            return true;
        }

        // Produces x^y mod n
        // T(n) = aT(n/b) + O(n^d)
        // T(n) = 1T(n/2) + O(n^3)
        // O(n^3)
        private long mod_exp(long x, long y, long n) {
            if(y == 0)
                return 1;
            long z = mod_exp(x, y / 2, n);
            if ((y & 1) == 1) {// means y is odd
                // return x * z^2 mod n
                long returnValue = x * ((z * z) % n) % n;
                return returnValue;
            } else {
                // return z^2 mod n
                long returnValue = (z * z) % n;
                return returnValue;
            }
        }
    }
}
