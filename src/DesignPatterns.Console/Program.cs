using DesignPatterns.Behavioral.Strategy;

HairCut hairCut = new(new TexturedCrop());
hairCut.DoHairCut();

hairCut.SetHairCut(new Caesar());
hairCut.DoHairCut();

hairCut.SetHairCut(new FlatTop());
hairCut.DoHairCut();

Console.ReadKey();