
/* <summary>
   Represents different levels of risk for mammals in each country using an enumeration.
   Author: Eduardo
   Last Modified: 25/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents different levels of risk for mammals in each country
    public enum RiskLevel
    {
        // Risk level indicating that the species is of least concern and is not currently at risk
        [Display(Name = "Least Concern")]
        LeastConcern = 1,
        
        // Risk level indicating that the species is near threatened and may become at risk in the near future
        [Display(Name = "Near Threatened")]
        NearThreatened = 2,
        
        // Risk level indicating that the species is vulnerable and is at high risk of endangerment
        Vulnerable = 3,
     
        // Risk level indicating that the species is endangered and faces a very high risk of extinction
        Endangered = 4,
        
        // Risk level indicating that the species is critically endangered and is facing an extremely high risk of extinction
        [Display(Name = "Critically Endangered")]
        CriticallyEndangered = 5,
        
        // Risk level indicating that the species is extinct in the wild and only exists in captivity
        [Display(Name = "Extinct in the Wild")]
        ExtinctInTheWild = 6,
        
        // Risk level indicating that the species is completely extinct and no longer exists
        Extinct = 7
    }
}