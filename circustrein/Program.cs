using circustrein;
using System.Diagnostics;
using System.Globalization;

Animal cs = new Animal("cat", _Size.small, _Diet.carnivore);
Animal cm = new Animal("wolf", _Size.medium, _Diet.carnivore);
Animal cl = new Animal("tiger", _Size.large, _Diet.carnivore);
Animal hs = new Animal("rabbit", _Size.small, _Diet.herbivore);
Animal hm = new Animal("horse", _Size.medium, _Diet.herbivore);
Animal hl = new Animal("elephant", _Size.large, _Diet.herbivore);

List<Animal> Animals = new List<Animal>
{
    cs, hm, hm, hm, hl, hl
};

Sort Test = new Sort();

Test.SortList(Animals);