using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string _gender;
        public Animal(string name, int age, string gender)
        {
            if (string.IsNullOrWhiteSpace(name)) 
                throw new ArgumentException();

            if (age < 0) throw new ArgumentException();

            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get;}
        public int Age { get;}
        public string Gender {
            get => this._gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                this._gender = value;
            }
        }

        public virtual string ProduceSound() => "";

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append(this.ProduceSound().TrimEnd());
            return sb.ToString();
        }
    }

}
