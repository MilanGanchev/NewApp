using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApp1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Desktop\Portfolio\NewApp.txt";

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split('|');

                Person newPerson = new Person();

                newPerson.number = entries[0];
                newPerson.name = entries[1];
                newPerson.job = entries[2];
                newPerson.income = entries[3];

                people.Add(newPerson);
            }
            foreach (var person in people)
            {
               MessageBox.Show($"{person.number}|{person.name}|{person.job}|{person.income}");
            }
            Console.ReadLine();
        }
    }
}
