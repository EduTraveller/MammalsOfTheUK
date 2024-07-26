
/* <summary>
   Represents a Risk Category entity, classifying risk levels for mammals by country.
   Author: Eduardo
   Last Modified: 25/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a Risk Category entity, which classifies risk levels for mammals by country
    public class RiskCategory
    {
        // Unique identifier for the mammal. This ID links the risk category to a specific mammal.
        public int MammalID { get; set; }

        // Risk level for the mammal in England. Nullable to handle cases where the risk level might not be applicable.
        public RiskLevel? England { get; set; }

        // Risk level for the mammal in Wales. Nullable to handle cases where the risk level might not be applicable.
        public RiskLevel? Wales { get; set; }

        // Risk level for the mammal in Scotland. Nullable to handle cases where the risk level might not be applicable.
        public RiskLevel? Scotland { get; set; }

        // Risk level for the mammal in Northern Ireland. Nullable to handle cases where the risk level might not be applicable.
        // Display name for UI purposes
        [Display(Name = "Northern Ireland")]
        public RiskLevel? NorthernIreland { get; set; }
    }
}