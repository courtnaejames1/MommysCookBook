using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mommy_sCookBook.Models
{
    public class InstructionsModel
    {
        /// <summary>
        /// Unique Identifier for the instruction Model
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the Instructions Description
        /// </summary>
        public string InstructionsDescription { get; set; }
    }
}
