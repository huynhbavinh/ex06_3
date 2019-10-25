using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_3
{
    public class Queue
    {
        private int[] space;
        private int bot;
        private int statue=0;
        public Queue(int size)
        {
            space = new int [size];
        }         
        public Queue()
        {
            space = new int[100];
            bot = -1;
        }
        public void En(int number)
        {
            space[bot + 1] = number;
            statue++;
            bot++;
        }
        public int De()
        {
            int temp = space[statue - bot - 1];
            bot--;
            return temp;
        }
        public int peek()
        {
            return space[statue - bot - 1];
        }
        public int CheckCount()
        {
            return bot+1;
        }
        public void clear()
        {
            bot = -1;
            statue = 0;
        }
    }
}
