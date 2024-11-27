using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ITC_Nov
{
    internal class myself
    {
        static void Main(string[] args)
        {
            string name = "Ko Zaw Htet";
            string address = "Yangon";
            int age = 27;
            string education = "Bachelor of Computer Science";
            string university = "Yangon";
            int year = 2018;

            string ambition = "Backend Developer";

            string myself = $"My name is {name} and I'm from {address}. I am {age} years old and graduated with {education} from \n{university} since {year}. I want to be a professional {ambition} because I am passionate about creating efficient,\nscalable systems that power applications and solve real-world problems. I enjoy working with data, optimizing \nperformance, and ensuring that users can interact with applications seamlessly. The challenge of designing robust \nback-end systems and building the infrastructure behind web applications excites me. Additionally, I find it rewarding \nto work on technologies that help applications run smoothly, securely, and at scale.";

            Console.WriteLine(myself);




        }
    }
}
