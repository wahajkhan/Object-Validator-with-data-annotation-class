using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Object_Validator
{
    public class Validate
    {
        public Validation_Result ObjValidate(object obj)
        {
            if (obj == null)
            {
                var result = new Validation_Result();
                result.AddError("Object","Object is null." );

                return result;
            }

            var objectType = obj.GetType();

            var properties = objectType.GetProperties();

            var validation_Result = new Validation_Result();

            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(obj);

                var attributes = property.GetCustomAttributes<ValidationAttribute>();

                foreach(var attribute in attributes)
                {
                    var isValid = attribute.IsValid(propertyValue);
                    if(!isValid)
                    {
                        var errorMessage = attribute.FormatErrorMessage(propertyName);
                        validation_Result.AddError(propertyName, errorMessage);
                    }
                }

            }



            return validation_Result;


        }



    }
}
