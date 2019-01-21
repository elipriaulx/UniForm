using System.Collections.Generic;
using UniForm.Core.Attributes.Composition;
using UniForm.Core.Models;

namespace UniForm.Examples.Wpf.Models
{
    [UniForm("Example Cat Form", "An example form about cats.")]
    public class ExampleCatForm
    {
        public enum CatFoods { Chicken, Duck, Moth, Mouse, Grasshopper }

        [UniFormField(priority: 0)]
        public string Name { get; set; } = "Archibald";

        [UniFormField(priority: 1)]
        public string Occupation { get; set; } = "Lap Warmer";
        
        [UniFormField("Hated Snacks")]
        public ISet<CatFoods> HatedSnacks { get; set; } = new HashSet<CatFoods>();

        [UniFormField("Favourite Snack")]
        public CatFoods FavouriteSnack { get; set; } = CatFoods.Moth;

        [UniFormField("Bio", "A short biography.", type: UniFormFieldTypes.BlobString)]
        public string Biography { get; set; } = "Archibald was no ordinary cat. Sure he had 4 legs and a tail, and 12 crooked whiskers which complimented his stubborn eye brows; but his idiosyncratic nature earned him top position in a league of his own.";

        [UniFormField("Friend Names", type: UniFormFieldTypes.AutoCollection)]
        public List<string> FriendNames { get; set; } = new List<string>();

        [UniFormField("Favourite Activites", priority: 1000, type: UniFormFieldTypes.AutoSelection)]
        [UniFormFieldSourceCollection(nameof(MostFavouriteActivity))]
        public List<string> FavouriteActivities { get; set; } = new List<string>();

        [UniFormField("Favourite Activity of All", priority: 1010, type: UniFormFieldTypes.AutoSelection)]
        public string MostFavouriteActivity { get; set; }

        [UniFormFieldIgnored]
        [UniFormFieldSourceCollection(nameof(FavouriteActivities))]
        public List<string> CatActivities { get; } = new List<string>
        {
            "Sleeping",
            "Eating",
            "Licking Paws",
            "Hiding Evidence"
        };
    }
}
