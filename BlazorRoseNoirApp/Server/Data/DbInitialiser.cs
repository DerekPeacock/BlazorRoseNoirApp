using BlazorRoseNoirApp.Shared;

namespace BlazorRoseNoirApp.Server.Data
{
    public static class DbIntialiser
    {
        public static void SeedData(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            AddProducts(context);
            AddVariations(context);
        }

        private static void AddProducts(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
			    new Product
                {
                    //ProductId = 1,
                    Name = "Crumble Candle",
                    Description = "A sweet and fruity delight combined with custard, vanilla, malt,"
                        + " cream, strawberry, red berries and pink rhubarb combine in this super"
                        + " strong fragrance.",
                    MainImageUrl = "CandleCrumble.png",
                    Price = 22.50m,
                    Discount = 0,
                    Category = Categories.Candles,
                    CountryOfOrigin = "uk",
                    IngredientList = "Ingredients",
                    AllergenList = "Top Notes: Lemon, Lime, Mint, Cognac\r\n" +
                    "\r\nHeart Notes: Jasmine, Iriswood, Clove, Vetivert\r\n" +
                    "\r\nBase Notes: Oak, Incense, Tobacco, Musk"
                },
			    new Product
                {
                    //ProductId = 2,
                    Name = "Plum Pudding Candle",
                    Description = "A combination of vibrant, fruity accord of juicy black plum,"
                        + " blackberry and fresh rhubarb supported with interludes of ripe pear"
                        + " and sweet peach.",
                    MainImageUrl = "CandlePlumPudding.png",
                    Price = 22.50m,
                    Discount = 0,
                    Category = Categories.Candles,
                    CountryOfOrigin = "uk",
                    IngredientList = "Top Notes: Rhubarb\r\n" +
                    "\r\nHeart Notes: Pear, Peach\r\n" +
                    "\r\nBase Notes: Plum, Blackberry",
                    AllergenList = "Always remove the candle cover prior to lighting." +
                    " Always burn on a protected, non-combustible, heat-resistant surface. " +
                    "Handle candles with care as containers may become hot.",
                },
			    new Product
                {
                    //ProductId = 3,
                    Name = "Lilly of the Valley",
                    Description = "Our natural soy wax candles are sustainable and blended with high-quality fragrances "
                    +"and hand-poured into recyclable/refill and elegant glass jars with beautiful wooden lids to provide"
                    +" your home with a delicately scented steady burn time of up to 90 hours, (depending on size). "
                    +"Our candles are presented in a beautiful design box (which may change from time to time), "
                    +"providing you with the perfect gift for all occasions.",
                    MainImageUrl = "Lily_of_the_valleyIMG_2224.JPG",
                    Price = 22.50m,
                    Discount = 0,
                    Category = Categories.Candles,
                    CountryOfOrigin = "uk",
                    IngredientList = "Top Notes: Rhubarb\r\n" +
                    "\r\nHeart Notes: Pear, Peach\r\n" +
                    "\r\nBase Notes: Plum, Blackberry",
                    AllergenList = "Always remove the candle cover prior to lighting. " +
                    "Always burn on a protected, non-combustible, heat-resistant surface. " +
                    "Handle candles with care as containers may become hot.",//NO ALLERGEN LIST FOR CANDLES
                },
			    new Product
                {
                    //ProductId = 4,
                    Name = "Lemon Drizzle Candle",
                    Description = "Our natural soy wax candles are sustainable and blended with high-quality fragrances and "
                    +"hand-poured into recyclable/refill and elegant glass jars with beautiful wooden lids to provide your home"
                    +" with a delicately scented steady burn time of up to 90 hours, (depending on size). "
                    +"Our candles are presented in a beautiful design box (which may change from time to time), "
                    +"providing you with the perfect gift for all occasions.",
                    MainImageUrl = "LemonDrizzelCandleIMG_2154.JPG",//TO DO
				    Price = 22.50m,
                    Discount = 0,
                    Category = Categories.Candles,
                    CountryOfOrigin = "uk",
                    IngredientList = "Top notes: fruity, rhubarb, apple, red berries, green\r\n" +
                    "\r\nheart notes: rhubarb, strawberry\r\n" +
                    "\r\nbase notes: sweet, creamy, vanilla, custard",
                    AllergenList = "Always remove the candle cover prior to lighting. " +
                    "Always burn on a protected, non-combustible, heat-resistant surface. " +
                    "Handle candles with care as containers may become hot."
                },
			    new Product
                {
                    //ProductId = 5,
                    Name = "Cuban Oak Diffuser",
                    Description = "Aromatic vintage cologne notes lead into a heart of rich sweet tobacco, warm spices and a hint of cognac. "
                    +"Smokey woods of oak, ebony and incense combine with dark musk to complete this fragrance.",
                    MainImageUrl = "CandlePlumPudding.png",//TO DO
				    Price = 22.50m,
                    Discount = 0,
                    Category = Categories.ReedDiffusers,
                    CountryOfOrigin = "uk",
                    IngredientList = "Top Notes: Lemon, Lime, Mint, Cognac\r" +
                    "\nHeart Notes: Jasmine, Iriswood, Clove, Vetivert\r" +
                    "\nBase Notes: Oak, Incense, Tobacco, Musk\r" +
                    "\n",
                    AllergenList = "Allergens",//NO ALLERGEN LIST FOR CANDLES
                },
			    new Product
                {
                    //ProductId = 6,
                    Name = "Pandoras Box Diffuser",
                    Description = "",
                    MainImageUrl = "CandlePlumPudding.png",//TO DO
				    Price = 22.50m,
                    Discount = 0,
                    Category = Categories.ReedDiffusers,
                    CountryOfOrigin = "uk",
                    IngredientList = "Top notes: bergamot, orange, green leaf, nutmeg, pepper\r"
                    +"\nHeart notes: clove, lavender, patchouli, amber\r"
                    +"\nBase notes: vetyvert, sandalwood, cedarwood, moss, tonka\r\n",
                    AllergenList = "Allergens",//NO ALLERGEN LIST FOR CANDLES
                },
			    new Product
                {
                    //ProductId = 7,
                    Name = "Citric Delight",
                    Description = "Grapefruit, Lime & Sweet Orange ",
                    MainImageUrl = "CandlePlumPudding.png",//TO DO
				    Price = 22.50m,
                    Discount = 0,
                    Category = Categories.BathShowers,
                    CountryOfOrigin = "UK",
                    IngredientList = "Sodium bicarbonate, Citric acid, Prunus armeniaca kernel oil (Sweet almond oil), "
                    +"Theobroma cacao seed butter (Cocoa), Hamamelis virginiana extract (Witch hazel), Kaolin clay, "
                    +"Polysorbate 80, Zea mays starch (Corn starch), Sodium Chloride (Dead Sea salt), Goat milk powder, "
                    +"Citrus Grandis (Grapefruit), Citrus Sinensis (Sweet orange), Citrus limon (Lemon) CI10020, CI19140.",
                    AllergenList = "May contains alpha-iso-Methylionone, Amyl Cinnamal, Citronellol, Coumarin, Eugenol, "
                    +"Geraniol, Limonene and Linalool which may produce an allergic reaction.",
                },
			    new Product
                {
                    //ProductId = 8,
                    Name = "Stress Buster",
                    Description = "This is a simple but classic scent. A fruity, floral combination of cranberries"
                    +"followed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,"
                    +"cedar, musk and vanilla",
                    MainImageUrl = "CandlePlumPudding.png",//TO DO
				    Price = 3.00m,
                    Discount = 0,
                    Category = Categories.BathShowers,
                    CountryOfOrigin = "UK",
                    IngredientList = "Sodium bicarbonate, Citric acid, Prunus armeniaca kernel oil (Sweet almond oil),"
                    +"Theobroma cacao seed butter (Cocoa), Hamamelis virginiana extract (Witch hazel), Kaolin clay,"
                    +"Polysorbate 80, Zea mays starch (Corn starch), Sodium Chloride (Dead Sea salt), Goat milk powder,"
                    +"Salvia Officinalis (Sage), Rosmarinus Officinalis (Rosemary), Eugenia Caryophyllus (Clove), "
                    +"Sodium chloride (Dead Sea salt), Rose Centifolia flower (Rose petal).",
                    AllergenList = "May contains alpha-iso-Methylionone, Amyl Cinnamal, Citronellol, Coumarin, "
                    +"Eugenol, Geraniol, Limonene and Linalool which may produce an allergic reaction.",//NO ALLERGEN LIST FOR CANDLES
                },
				new Product
				{
					//ProductId = 9,
					Name = "Calm Bath Bomb",
					Description = "This is a simple but classic scent. A fruity, floral combination of cranberries"
					+"followed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,"
					+"cedar, musk and vanilla",
					MainImageUrl = "CandlePlumPudding.png",//TO DO
					Price = 3.00m,
					Discount = 0,
					Category = Categories.BathShowers,
					CountryOfOrigin = "UK",
					IngredientList = "Sodium bicarbonate, Citric acid, Prunus armeniaca kernel oil (Sweet almond oil),"
					+"Theobroma cacao seed butter (Cocoa), Hamamelis virginiana extract (Witch hazel), Kaolin clay,"
					+"Polysorbate 80, Zea mays starch (Corn starch), Sodium Chloride (Dead Sea salt), Goat milk powder,"
					+"Lavandula angustifolia oil (Lavender), CI45100, CI42090, Lavandula Angustifolia flower (Lavender flower)"
					+"Magnesium sulphate heptahydrate (Epsom salt).",
					AllergenList = "May contains alpha-iso-Methylionone, Amyl Cinnamal, Citronellol, Coumarin, Eugenol, "
					+"Geraniol, Limonene and Linalool which may produce an allergic reaction.,",
				},
				new Product
				{
					//ProductId = 10,
					Name = "Bergamot & Lavender",
					Description = "This is a simple but classic scent. A fruity, floral combination of cranberries"
					+"followed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,"
					+"cedar, musk and vanilla",
					MainImageUrl = "CandlePlumPudding.png",//TO DO
					Price = 3.00m,
					Discount = 0,
					Category = Categories.NaturalSoaps,
					CountryOfOrigin = "UK",
					IngredientList = "Aqua, Sodium olivate (Olive), Sodium palmate, (Sustainable RSPO certified);" +
					" Sodium cocoate (Coconut), Sodium almondate (Almond), Sodium cocoa butterate (Cocoa) " +
					"Sodium shea butterate (Shea), Sodium avocadate (Avocado), Sodium ricinoleate (Castor), " +
					"Citrus bergamia (Bergamot) essential oil, Lavandula augustifolia (Lavender) " +
					"essential oil, CI:77019, CI:77891, CI:77491, CI:77742.\r\n \r\n",
					AllergenList = "Geraniol, Limonene, Linalool"
				},
				new Product
				{
					//ProductId = 11,
					Name = "Stress Buster Bar",
					Description = "This is a simple but classic scent. A fruity, floral combination of cranberries"
					+"followed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,"
					+"cedar, musk and vanilla",
					MainImageUrl = "CandlePlumPudding.png",//TO DO
					Price = 3.00m,
					Discount = 0,
					Category = Categories.NaturalSoaps,
					CountryOfOrigin = "UK",
					IngredientList = "Aqua, Sodium olivate (Olive), Sodium palmate, (Sustainable RSPO certified); " +
					"Sodium cocoate (Coconut), Sodium almondate (Almond), Sodium cocoa butterate (Cocoa) " +
					"Sodium shea butterate (Shea), Sodium avocadate (Avocado), Sodium ricinoleate (Castor), " +
					"Spirulina platensis (Spirulina), Beta Vulgaris Rubra Root Powder (Beetroot), " +
					"Salvia Officinalis essential oil (Sage), Eugenia caryophyllus essential oil (Clove), " +
					"Rosmarinus officinalis essential oil (Rosemary).n",
					AllergenList = "Eugenol, Limonene, Geraniol, Linalool, Nerol, Linalyl acetate",
				},
				new Product
				{
					//ProductId = 12,
					Name = "Oatmeal & Tea Tree",
					Description = "This is a simple but classic scent. A fruity, floral combination of cranberries"
					+"followed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,"
					+"cedar, musk and vanilla",
					MainImageUrl = "CandlePlumPudding.png",//TO DO
					Price = 3.00m,
					Discount = 0,
					Category = Categories.NaturalSoaps,
					CountryOfOrigin = "UK",
					IngredientList = "qua, Sodium olivate (Olive), Sodium palmate, (Sustainable RSPO certified); " +
					"Sodium cocoate (Coconut), Sodium almondate (Almond), Sodium cocoa butterate (Cocoa) " +
					"Sodium shea butterate (Shea), Sodium avocadate (Avocado), Sodium ricinoleate (Castor), " +
					"Carbo activates (Charcoal), Oat Flour Avena Sativa (Oatmeal), Spirulina platensis (Spirulina), " +
					"Titanium Dioxide (CI 77891), Melaleuca Alternifolia essential oil (Tea tree)\r\n \r\n",
					AllergenList = "Geraniol, Limonene, Linalool",
				}
			};

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
        private static void AddVariations(ApplicationDbContext context)
        {
            if (context.Variations.Any())
            {
                return;
            }

            var variations = new Variation[]
            {
                new Variation
                {
					//Id = 1,
					ProductId = 1,
                    AvailableStock = 1,
                    Name = "Glass size H 83mm D 70mm",
                    Description = "Approx. burn time: 30-35 hours",
                    ImageUrl = string.Empty,
                    Weight = 150,
                    WeightUnit = WeightUnits.g,
                    Size = 20,
                    SizeUnit = SizeUnits.cl,
                    VariationType = VariationTypes.Sizes,
                    Price = 22.50m,
                },
                new Variation
                {
					//Id = 2,
					ProductId = 1,
                    AvailableStock = 1,
                    Name = "Glass size H 93mm D 78mm",
                    Description = "Approx. burn time: 40-45 hours",
                    ImageUrl = string.Empty,
                    Weight = 250,
                    WeightUnit = WeightUnits.g,
                    Size = 30,
                    SizeUnit = SizeUnits.cl,
                    VariationType = VariationTypes.Sizes,
                    Price = 35.00m,
                },
                new Variation
                {
					//Id = 3,
					ProductId = 2,
                    AvailableStock = 1,
                    Name = "Glass size H 83mm D 70mm",
                    Description = "Approx. burn time: 30-35 hours",
                    ImageUrl = string.Empty,
                    Weight = 150,
                    WeightUnit = WeightUnits.g,
                    Size = 20,
                    SizeUnit = SizeUnits.cl,
                    VariationType = VariationTypes.Sizes,
                    Price = 22.50m,
                },
                new Variation
                {
					//Id = 4,
					ProductId = 2,
                    AvailableStock = 1,
                    Name = "Glass size H 93mm D 78mm",
                    Description = "Approx. burn time: 40-45 hours",
                    ImageUrl = string.Empty,
                    Weight = 250,
                    WeightUnit = WeightUnits.g,
                    Size = 30,
                    SizeUnit = SizeUnits.cl,
                    VariationType = VariationTypes.Sizes,
                    Price = 35.00m,
                },
				new Variation
				{
					//Id = 5,
					ProductId = 3,
					AvailableStock = 1,
					Name = "Glass size H 83mm D 70mm",
					Description = "Approx. burn time: 30-35 hours",
					ImageUrl = string.Empty,
					Weight = 150,
					WeightUnit = WeightUnits.g,
					Size = 20,
					SizeUnit = SizeUnits.cl,
					VariationType = VariationTypes.Sizes,
					Price = 22.50m,
				},
				new Variation
				{
					//Id = 6,
					ProductId = 3,
					AvailableStock = 1,
					Name = "Glass size H 93mm D 78mm",
					Description = "Approx. burn time: 40-45 hours",
					ImageUrl = string.Empty,
					Weight = 250,
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.cl,
					VariationType = VariationTypes.Sizes,
					Price = 27.00m,
				},
				new Variation
				{
					//Id = 7,
					ProductId = 4,
					AvailableStock = 1,
					Name = "Glass size H 83mm D 70mm",
					Description = "Approx. burn time: 30-35 hours",
					ImageUrl = string.Empty,
					Weight = 150,
					WeightUnit = WeightUnits.g,
					Size = 20,
					SizeUnit = SizeUnits.cl,
					VariationType = VariationTypes.Sizes,
					Price = 31.51m,
				},
				new Variation
				{
					//Id = 8,
					ProductId = 4,
					AvailableStock = 1,
					Name = "Glass size H 93mm D 78mm",
					Description = "Approx. burn time: 40-45 hours",
					ImageUrl = string.Empty,
					Weight = 250,
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.cl,
					VariationType = VariationTypes.Sizes,
					Price = 36.00m,
				},
				new Variation
				{
					//Id = 9,
					ProductId = 5,
					AvailableStock = 1,
					Name = "Glass size H 83mm D 70mm",//NO INFO PROVIDED
					Description = "Approx. burn time: 30-35 hours",
					ImageUrl = string.Empty,
					Weight = 150,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 50,
					SizeUnit = SizeUnits.ml,
					VariationType = VariationTypes.Sizes,
					Price = 15.00m,
				},
				new Variation
				{
					//Id = 10,
					ProductId = 5,
					AvailableStock = 1,
					Name = "Glass size H 93mm D 78mm",//NO INFO PROVIDED
					Description = "Approx. burn time: 40-45 hours",
					ImageUrl = string.Empty,
					Weight = 250,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.ml,
					VariationType = VariationTypes.Sizes,
					Price = 26.95m,
				},
				new Variation
				{
					//Id = 11,
					ProductId = 6,
					AvailableStock = 1,
					Name = "Glass size H 83mm D 70mm",//NO INFO PROVIDED
					Description = "Approx. burn time: 30-35 hours",
					ImageUrl = string.Empty,
					Weight = 150,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 50,
					SizeUnit = SizeUnits.ml,
					VariationType = VariationTypes.Sizes,
					Price = 15.00m,
				},
				new Variation
				{
					//Id = 12,
					ProductId = 6,
					AvailableStock = 1,
					Name = "Glass size H 93mm D 78mm",//NO INFO PROVIDED
					Description = "Approx. burn time: 40-45 hours",
					ImageUrl = string.Empty,
					Weight = 250,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.ml,
					VariationType = VariationTypes.Sizes,
					Price = 27.95m,
				},
				new Variation
				{
					//Id = 13,
					ProductId = 7,
					AvailableStock = 2,
					Name = "Size Doughnut Shape",
					Description = "Although our bath bombs have a shelf life of 12 months in optimal conditions,"
					+"over time the colours and scent will fade. We recommend using a bath bomb within 6 months of purchase.",
					ImageUrl = string.Empty,
					Weight = 165,
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 3.00m,
				},
				new Variation
				{
					//Id = 14,
					ProductId = 7,
					AvailableStock = 3,
					Name = "Size Round Shape ",
					Description = "Although our bath bombs have a shelf life of 12 months in optimal conditions,"
					+"over time the colours and scent will fade. We recommend using a bath bomb within 6 months of purchase",
					ImageUrl = string.Empty,
					Weight = 165,
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 5.00m,
				},
				new Variation
				{
					//Id = 15,
					ProductId = 7,
					AvailableStock = 4,
					Name = "Size Football Shape ",
					Description = "Although our bath bombs have a shelf life of 12 months in optimal conditions,"
					+"over time the colours and scent will fade. We recommend using a bath bomb within 6 months of purchase",
					ImageUrl = string.Empty,
					Weight = 165,
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 3.00m,
				},
				new Variation
				{
					//Id = 16,
					ProductId = 8,
					AvailableStock = 1,
					Name = "Size Doughnut Shape",//NO INFO PROVIDED
					Description = "Rosemary, Clove & Sage",
					ImageUrl = string.Empty,
					Weight = 150,//TO DO
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 3.00m,
				},
				new Variation
				{
					//Id = 17,
					ProductId = 8,
					AvailableStock = 1,
					Name = "Size Round Shape",
					Description = "Rosemary, Clove & Sage",
					ImageUrl = string.Empty,
					Weight = 250,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.cl,//TO CONFIRM
					VariationType = VariationTypes.Sizes,
					Price = 5.00m,
				},
				new Variation
				{
					//Id = 18,
					ProductId = 8,
					AvailableStock = 1,
					Name = "Size Football Shape",
					Description = "Rosemary, Clove & Sage",
					ImageUrl = string.Empty,
					Weight = 250,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.ml,
					VariationType = VariationTypes.Sizes,
					Price = 3.00m,
				},
				new Variation
				{
					//Id = 18,
					ProductId = 9,
					AvailableStock = 1,
					Name = "Size Doughnut Shape",//NO INFO PROVIDED
					Description = "Sweet Almond Oil, \nCocoa, \nWitch Hazel, \nLavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 150,//TO DO
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 3.00m,
				},
				new Variation
				{
					//Id = 19,
					ProductId = 9,
					AvailableStock = 1,
					Name = "Size Round Shape",
					Description = "Sweet Almond Oil, \nCocoa, \nWitch Hazel,\n Lavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 250,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.cl,//TO CONFIRM
					VariationType = VariationTypes.Sizes,
					Price = 5.00m,
				},
				new Variation
				{
					//Id = 20,
					ProductId = 9,
					AvailableStock = 1,
					Name = "Size Football Shape",
					Description = "Sweet Almond Oil, \nCocoa, \nWitch Hazel, \nLavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 250,//TO DO
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.ml,
					VariationType = VariationTypes.Sizes,
					Price = 3.00m,
				},
				new Variation
				{
					//Id = 21,
					ProductId = 10,
					AvailableStock = 1,
					Name = "Medium",//NO INFO PROVIDED
					Description = "Sweet Almond Oil, \nCocoa, \nWitch Hazel, \nLavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 75,//TO DO
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 4.50m,
				},
				new Variation
				{
					//Id = 22,
					ProductId = 10,
					AvailableStock = 1,
					Name = "Large",
					Description = "Sweet Almond Oil, \nCocoa, \nWitch Hazel, \nLavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 105,
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.cl,//TO CONFIRM
					VariationType = VariationTypes.Sizes,
					Price = 5.50m,
				},
				new Variation
				{
					//Id = 23,
					ProductId = 11,
					AvailableStock = 1,
					Name = "Medium",
					Description = "Sweet Almond Oil, Cocoa, Witch Hazel, Lavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 75,
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 4.00m,
				},
				new Variation
				{
					//Id = 24,
					ProductId = 11,
					AvailableStock = 1,
					Name = "Large",
					Description = "Sweet Almond Oil, Cocoa, Witch Hazel, Lavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 105,
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.cl,//TO CONFIRM
					VariationType = VariationTypes.Sizes,
					Price = 6.00m,
				},
				new Variation
				{
					//Id = 24,
					ProductId = 12,
					AvailableStock = 1,
					Name = "Medium",//NO INFO PROVIDED
					Description = "Sweet Almond Oil, Cocoa, Witch Hazel, Lavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 75,//TO DO
					WeightUnit = WeightUnits.g,
					VariationType = VariationTypes.Sizes,
					Price = 4.50m,
				},
				new Variation
				{
					//Id = 25,
					ProductId = 12,
					AvailableStock = 1,
					Name = "Large",
					Description = "Sweet Almond Oil, Cocoa, Witch Hazel, Lavenda & Epsom Salt",
					ImageUrl = string.Empty,
					Weight = 105,
					WeightUnit = WeightUnits.g,
					Size = 30,
					SizeUnit = SizeUnits.cl,
					VariationType = VariationTypes.Sizes,
					Price = 6.00m,
				},
			};

            foreach (var variation in variations)
            {
                context.Variations.Add(variation);
            }

            context.SaveChanges();
        }
    }
}
