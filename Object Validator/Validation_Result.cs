using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Validator
{
    public class Validation_Result
    {
        public Validation_Result()
            => this.Errors = new Dictionary<string, List<string>>();
        

        public bool IsValid => !this.Errors.Any();

        public Dictionary<string, List<string>> Errors { get; }


        public void AddError (string name , string message)
        {
            if (!this.Errors.ContainsKey(name))
            {
                this.Errors[name] = new List<string>();

            }                
                this.Errors[name].Add(message);

        }


    }
}
