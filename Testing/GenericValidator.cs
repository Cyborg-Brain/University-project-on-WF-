using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;

namespace Testing
{
    public class GenericValidator  
    {
        public ValidationContext TryValidation<TEntity>(TEntity entity, out ICollection<ValidationResult> results) where TEntity : class
        {
            var context = new ValidationContext(entity, serviceProvider: null, items: null);
            results = new List<ValidationResult>();
            return context;
            //return Validator.TryValidateObject(entity, context, results, validateAllProperties:true);
        }
    }
}
